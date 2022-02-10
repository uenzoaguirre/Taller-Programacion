using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.DAL;
using Aplication.DAL.EntityFramework;

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


        public void AgregarUsuario(DTOUsuario usuario, bool esAdmin)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Usuario usuario1 = new Usuario
                {
                    NombreUsuario = usuario.Nombre,
                    Dni = usuario.Dni,
                    Password = usuario.Password,
                    Mail = usuario.Mail,
                    FechaRegistro = usuario.FechaRegistro,
                    Puntaje = usuario.Puntaje,
                    EsAdministrador = esAdmin



                };
                bUoW.RepositorioUsuarios.Agregar(usuario1);
                bUoW.Complete();


            }

        }

        public void AgregarEjemplar(DTOEjemplar ejemplar)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Edicion edition;
                if (ejemplar.Edicion.Id.Length == 0)
                {
                    edition = new Edicion
                    {
                        Isbn = ejemplar.Edicion.Isbn,
                        AñoEdicion = ejemplar.Edicion.AnioEdicion,
                        NumeroPaginas = ejemplar.Edicion.NumeroPaginas,
                        Portada = ejemplar.Edicion.Portada,
                        FechaPublicacion = ejemplar.Edicion.FechaPublicacion,
                        // if (ejemplar.Edicion.Obra )



                    };

                }
                Ejemplar ejemplar1 = new Ejemplar
                {






                };
            }
        }




        public List<DTOPrestamo> PrestamosProximosAVencer(string dni)
        {
            throw new NotImplementedException();
        }

        public List<DTOPrestamo> ListarPrestamos(string dni)
        {
            throw new NotImplementedException();
        }

        public List<DTOPrestamo> PrestamosEntreFechas(string dni, DateTime fechaInicio, DateTime fechaFin)
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

        public List<DTOEdicion> ListarEdiciones(DTOEdicion edicion)
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
        public void BajaUsuario(string dni)
        {

        }
        public bool ExisteUsuario(DTOUsuario usuario)
        {
            throw new NotImplementedException();
        }
        public void ModificarDatosUsuario(string dni, DTOUsuario usuario)
        {

        }
        public bool LoguearUsuario(string nombreUsuario, string password)
        {
            bool contraCorrecta;

            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Usuario us1 = bUoW.RepositorioUsuarios.ObtenerPorNombreDeUsuario(nombreUsuario);
                contraCorrecta = us1.Password == password;
                bUoW.Complete();

            }
            return contraCorrecta;
        }
        public void PrestarEjemplar(string dni, string codigoInventario)
        {

        }
        public void DevolverEjemplar(string dni, int idPrestamo, bool buenEstado)
        {

        }
        public void BajaEjemplar(string codigoInventario, string isbn)
        {

        }



    }
}