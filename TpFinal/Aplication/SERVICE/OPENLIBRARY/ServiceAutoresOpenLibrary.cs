using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Aplication
{
    public class ServiceAutoresOpenLibrary
    {
       public static List<DTOAutor> Buscar(Dictionary<string, string> pFiltros)
        {
            // Establecimiento del protocolo ssl de transporte
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (pFiltros.Count == 0)
            {
                throw new Exception("Se nececita filtrar por Id o Nombre");
            }
            // Url de ejemplo
            string mUrl = "";
            if (pFiltros.ContainsKey("Id"))
            {
                mUrl = String.Format("https://openlibrary.org/authors/{0}.json", pFiltros["Id"]);
            }
            else if (pFiltros.ContainsKey("Nombre"))
            {
                mUrl = String.Format("https://openlibrary.org/search/authors.json?q={0}", HttpUtility.HtmlEncode(pFiltros["Nombre"]));
            }

            List<DTOAutor> autores = new List<DTOAutor>();


            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    System.Console.WriteLine("numFound: {0}", mResponseJSON.numFound);

                    // Se iteran cada uno de los resultados.
                    if (pFiltros.ContainsKey("Nombre"))
                    {
                        foreach (var bResponseItem in mResponseJSON.docs)
                        {
                            DTOAutor autor = new DTOAutor();
                            autor.Nombre = HttpUtility.HtmlDecode(bResponseItem.name.ToString());
                            if (bResponseItem.ContainsKey("alternate_names"))
                            {
                                foreach (var bNombreAlternativo in bResponseItem.alternate_names)
                                {
                                    autor.NombresAlternativos.Add(bNombreAlternativo.Value);
                                }
                            }
                            autores.Add(autor);
                        }
                    }
                    else if (pFiltros.ContainsKey("Id"))
                    {
                        DTOAutor autor = new DTOAutor();
                        autor.NombresAlternativos = new List<string>();
                        autor.Nombre = HttpUtility.HtmlDecode(mResponseJSON.name.ToString());
                        foreach (var bNombreAlternativo in mResponseJSON.alternate_names)
                        {
                            autor.NombresAlternativos.Add(bNombreAlternativo.Value);
                        }
                        autores.Add(autor);
                    }

                }
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: {0}", ex.Message);
            }
            return autores;
        }
    }

}