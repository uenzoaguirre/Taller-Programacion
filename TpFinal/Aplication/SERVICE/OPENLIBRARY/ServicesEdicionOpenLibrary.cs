using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Globalization;

namespace Aplication
{
    public class ServiceEdicionesOpenLibrary
    {
       public static List<DTOEdicion> Buscar(Dictionary<string, string> pFiltros)
        {
            // Establecimiento del protocolo ssl de transporte
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (pFiltros.Count == 0)
            {
                throw new Exception("Se nececita filtrar por ISBN");
            }
            string mUrl = "";
            if (pFiltros.ContainsKey("ISBN"))
            {
                mUrl = String.Format("https://openlibrary.org/isbn/{0}.json", pFiltros["ISBN"]);
            }
            List<DTOEdicion> ediciones = new List<DTOEdicion>();


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

                    // Se iteran cada uno de los resultados.

                    DTOEdicion edicion = new DTOEdicion();
                    edicion.Isbn = pFiltros["ISBN"];
                    edicion.Portada = String.Format("https://covers.openlibrary.org/b/isbn/{0}-L.jpg", pFiltros["ISBN"]);
                    edicion.numeroPaginas = mResponseJSON["number_of_pages"];
                    edicion.Edicion = mResponseJSON["revision"];
                    edicion.FechaPublicacion = DateTime.ParseExact((string)mResponseJSON["publish_date"] , "MMMM d, yyyy" , CultureInfo.InvariantCulture);
                    ediciones.Add(edicion); 

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
            return ediciones; 
        }
    }

}

