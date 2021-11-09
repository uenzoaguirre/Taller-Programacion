using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Fachada
    {
        public void AgregarUsuario(DTOUsuario usuario , bool esAdmin)
        {

        } 

        public void AgregarEjemplar(string codigoInventario, string isbn)
        {

        }
        public List<DTOPrestamo> PrestamosProximosAVencer(string dni) 
        {

        } 

        public List<DTOPrestamo> ListarPrestamos(string dni) 
        {

        }

        public  List<DTOPrestamo> PrestamosEntreFechas(string dni, DateTime fechaInicio ,DateTime fechaFin)
        {

        }

        public bool EsUsuarioAdmin(string nombreUsuario) 
        {

        }

        public List<DTOEjemplar> ListarEjemplares(dictionary<string,string> datos)
        {

        } 

        public List<DTOEdicion>ListarEdiciones(dictionary<string,string> datos)
        {

        } 

        public void AgregarEdicion(DTOEdicion edicion) 
        {
            
        }

        public bool ExisteEdicion(DTOEdicion edicion) 
        {

        }


        
    }
}