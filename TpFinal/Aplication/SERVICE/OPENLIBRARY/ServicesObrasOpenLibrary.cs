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
    public class ServicesObrasOpenLibrary
    {

        public static List<DTOObra> Buscar(Dictionary<string, string> pFiltros)
        {
            if (pFiltros.Count == 0)
            {
                throw new Exception("Se nececita filtrar por Id o Nombre");
            }
            // Url de ejemplo
            string mUrl = "";

            mUrl = String.Format("https://openlibrary.org/search.json?author={0}&title={1}", HttpUtility.HtmlEncode(pFiltros["Autor"]), HttpUtility.HtmlEncode(pFiltros["Titulo"]));


            List<DTOObra> obras = new List<DTOObra>();
            try
            {


                dynamic mResponseJSON = HttpJsonRequest.Obtener(mUrl);

                System.Console.WriteLine("numFound: {0}", mResponseJSON.numFound);

                // Se iteran cada uno de los resultados
                foreach (var bResponseItem in mResponseJSON.docs)
                {
                    DTOObra obra = new DTOObra();
                    obra.Autor = HttpUtility.HtmlDecode(bResponseItem.author_name.ToString());
                    obra.Titulo = HttpUtility.HtmlDecode(bResponseItem.title.ToString());
                    obra.Generos = new List<string>();
                    if (bResponseItem.ContainsKey("subject"))
                    {
                        foreach (var genero in bResponseItem.subject)
                        {
                            obra.Generos.Add(genero.Value);
                        }
                    }
                    
                    obra.Ediciones = new List<string>();
                    if (bResponseItem.ContainsKey("edition_key"))
                    {
                        foreach (var edicion in bResponseItem.edition_key)
                        {
                            obra.Generos.Add(edicion.Value);
                        }
                    }
                    obras.Add(obra);
                    
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
            return obras;

        }
    }
}
