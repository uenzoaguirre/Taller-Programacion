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
using Aplication.SERVICE.Http;

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

            try
            {
                dynamic mResponseJson = HttpJsonRequest.Obtener(mUrl);
                DTOEdicion edicion = new DTOEdicion();
                edicion.Isbn = pFiltros["ISBN"];
                edicion.Portada = String.Format("https://covers.openlibrary.org/b/isbn/{0}-L.jpg", pFiltros["ISBN"]);
                edicion.numeroPaginas = mResponseJson["number_of_pages"];
                edicion.Edicion = mResponseJson["revision"];
                edicion.FechaPublicacion = DateTime.ParseExact((string)mResponseJson["publish_date"], "MMMM d, yyyy", CultureInfo.InvariantCulture);
                ediciones.Add(edicion);
            }
            catch (ExcepcionConsultaWeb ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
            }
            catch (ExcepcionRespuestaInvalida ex1)
            {
                Console.WriteLine("Error {0}", ex1.Message); 
            }


            return ediciones;




        }
    }

}

