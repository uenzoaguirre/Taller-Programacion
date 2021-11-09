using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Fachada

    {
        IServicesObras obras;
        IServicesEdicion edicion1;
        IServicesAutores autores;

        IRepositorioPrestamo repoPrestamo; 
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

        public List<DTOEjemplar> ListarEjemplares(DTOEjemplar ejemplar)
        {

        } 

        public List<DTOEdicion> ListarEdiciones (DTOEdicion edicion)
        {

        } 

        public void AgregarEdicion(DTOEdicion edicion) 
        {
            
        }

        public bool ExisteEdicion(DTOEdicion edicion)
        {

        }
        public void BajaUsuario (string dni)
        {

        }
          public bool ExisteUsuario (DTOUsuario usuario)
        {

        } 
          public void ModificarDatosUsuario (string dni,DTOUsuario usuario)
        {

        }
          public bool LoguearUsuario (string nombreUsuario, string password)
        {

        }
          public void PrestarEjemplar (string dni, string codigoInventario)
        {

        }
          public void DevolverEjemplar (string dni, int idPrestamo, bool buenEstado)
        {

        }
          public void BajaEjemplar (string codigoInventario, string isbn)
        {

        }


        
    }
}