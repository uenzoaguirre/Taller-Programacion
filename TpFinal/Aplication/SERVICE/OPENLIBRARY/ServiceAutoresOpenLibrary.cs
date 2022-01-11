using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Aplication.SERVICE.Http;

namespace Aplication
{
    public class ServiceAutoresOpenLibrary
    {
        public static List<DTOAutor> Buscar(Dictionary<string, string> pFiltros)
        {

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
            try
            {


                dynamic mResponseJSON = HttpJsonRequest.Obtener(mUrl);

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
                            autor.NombresAlternativos = new List<string>();
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
            catch (ExcepcionConsultaWeb ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
            }
            catch (ExcepcionRespuestaInvalida ex1)
            {
                Console.WriteLine("Error {0}", ex1.Message);
            }

            return autores;
        }
    }
}
