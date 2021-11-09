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

        public void Baja (string dni)
        {

        }
          public bool ExisteUsuario (DTOUsuario usuario)
        {

        } 
          public void ModificarDatosUsuario (string dni,Dictionary<string,string> cambios)
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