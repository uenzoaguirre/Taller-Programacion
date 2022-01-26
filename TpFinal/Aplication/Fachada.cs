using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Fachada

    {
        IServicesObras obras;
        IServicesAutores autores;
        IRepositorioPrestamos repoPrestamo;
        IRepositorioUsuarios repoUsuarios; 
        IRepositorioEjemplares repoEjemplares;
        IRepositorioObras repoObras;


        public void AgregarUsuario(DTOUsuario usuario , bool esAdmin)
        {

        } 

        public void AgregarEjemplar(string codigoInventario, string isbn)
        {

        }
        public List<DTOPrestamo> PrestamosProximosAVencer(string dni) 
        {
          throw new NotImplementedException();
        } 

        public List<DTOPrestamo> ListarPrestamos(string dni) 
        {
          throw new NotImplementedException();
        }

        public  List<DTOPrestamo> PrestamosEntreFechas(string dni, DateTime fechaInicio ,DateTime fechaFin)
        {
          throw new NotImplementedException();
        }

        public bool EsUsuarioAdmin(string nombreUsuario) 
        {
          throw new NotImplementedException();
        }

        public List<DTOEjemplar> ListarEjemplares(DTOEjemplar ejemplar)
        {
          throw new NotImplementedException();
        } 

        public List<DTOEdicion> ListarEdiciones (DTOEdicion edicion)
        {
          throw new NotImplementedException();
        } 

        public void AgregarEdicion(DTOEdicion edicion) 
        {
            
        }

        public bool ExisteEdicion(DTOEdicion edicion)
        {
          throw new NotImplementedException();
        }
        public void BajaUsuario (string dni)
        {

        }
          public bool ExisteUsuario (DTOUsuario usuario)
        {
          throw new NotImplementedException();
        } 
          public void ModificarDatosUsuario (string dni,DTOUsuario usuario)
        {

        }
          public bool LoguearUsuario (string nombreUsuario, string password)
        {
          throw new NotImplementedException();
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