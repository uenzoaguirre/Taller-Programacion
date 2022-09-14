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

        public void AgregarObra(DTOObra obra)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Obra obra1 = new Obra
                {
                    Titulo = obra.Titulo,
                    Lccn = obra.Lccn,
                    Descripcion = obra.Descripcion,
                };

                bUoW.RepositorioObras.Agregar(obra1);
                bUoW.Complete();
            }
        }

        public void AgregarEjemplar(DTOEjemplar ejemplar)
        {
            if (ejemplar.Edicion.Id.Length == 0)
            {
                AgregarEdicion(ejemplar.Edicion);
            }
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Edicion edicion = bUoW.RepositorioEdiciones.ObtenerPorISBN(ejemplar.Edicion.Isbn);
                Ejemplar ejemplar1 = new Ejemplar
                {
                    Edicion = edicion,
                    FechaAlta = ejemplar.FechaAlta,
                    CodigoInventario = ejemplar.codigoInventario,
                };
                bUoW.RepositorioEjemplares.Agregar(ejemplar1);
                bUoW.Complete();
            }
        }


        public List<DTOPrestamo> PrestamosProximosAVencer(int dni)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
              var listaPrestamosProxAVencer = bUoW.RepositorioPrestamos.Search(u => u.Solicitante.Dni == dni && (u.FechaVencimiento - DateTime.Now).TotalDays < 7).ToList();
              return listaPrestamosProxAVencer.Select(p => new DTOPrestamo {Id = p.Id, FechaPrestamo = p.FechaPrestamo, FechaVencimiento = p.FechaVencimiento}).ToList();     
            }
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
            if (edicion.Obra.Lccn.Length == 0)
            {
                AgregarObra(edicion.Obra);
            }
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Obra obraNueva = bUoW.RepositorioObras.ObtenerPorLccn(edicion.Obra.Lccn);
                Edicion edition = new Edicion
                {
                    Isbn = edicion.Isbn,
                    AñoEdicion = edicion.AnioEdicion,
                    NumeroPaginas = edicion.NumeroPaginas,
                    Portada = edicion.Portada,
                    FechaPublicacion = edicion.FechaPublicacion,
                    Obra = obraNueva,
                };
                bUoW.RepositorioEdiciones.Agregar(edition);
                bUoW.Complete();
            }
        }

        public bool ExisteEdicion(DTOEdicion edicion)
        {
            throw new NotImplementedException();
        }
        public void BajaUsuario(int dni)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Usuario usuario = bUoW.RepositorioUsuarios.ObtenerPorDNI(dni);
                bUoW.RepositorioUsuarios.Eliminar(usuario);
                bUoW.Complete();
            }

        }
        public bool ExisteUsuario(DTOUsuario usuario)
        {
            throw new NotImplementedException();
        }
        public void ModificarDatosUsuario(int dni, DTOUsuario usuario)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Usuario usuario1 = bUoW.RepositorioUsuarios.ObtenerPorDNI(dni);
                if (usuario.Nombre.Length != 0)
                {
                    usuario1.NombreUsuario = usuario.Nombre;
                }

                if (usuario.Mail.Length != 0)
                {
                    usuario1.Mail = usuario.Mail;
                }

                if (usuario.Password.Length != 0)
                {
                    usuario1.Password = usuario.Password;
                }

                bUoW.Complete();
            }
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

        public void PrestarEjemplar(int dni, string codigoInventario)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                int dias = 5;
                Usuario usuario = bUoW.RepositorioUsuarios.ObtenerPorDNI(dni);
                Ejemplar ejemplar = bUoW.RepositorioEjemplares.ObtenerPorCodInv(codigoInventario);

                dias += usuario.Puntaje / 5;

                dias = Math.Min(dias, 15);

                var fechaVencimiento = DateTime.Now.AddDays(dias);

                Prestamo prestamo = new Prestamo
                {
                    FechaPrestamo = DateTime.Now,
                    FechaVencimiento = fechaVencimiento,
                    Solicitante = usuario,
                    Ejemplar = ejemplar,
                };

                bUoW.RepositorioPrestamos.Agregar(prestamo);
                bUoW.Complete();
            }
        }
        public void DevolverEjemplar(int dni, int idPrestamo, bool buenEstado)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Usuario usuario = bUoW.RepositorioUsuarios.ObtenerPorDNI(dni);
                Prestamo prestamo = bUoW.RepositorioPrestamos.Obtener(idPrestamo);

                prestamo.FechaDevolucion = DateTime.Now;

                if (!buenEstado)
                {
                    usuario.Puntaje -= 10;
                }

                if (DateTime.Now > prestamo.FechaVencimiento)
                {
                    usuario.Puntaje -= 2 * (int)(DateTime.Now - prestamo.FechaVencimiento).TotalDays;
                }

                if (buenEstado && prestamo.FechaVencimiento > DateTime.Now)
                {
                    usuario.Puntaje += 5;
                }

                bUoW.Complete();
            }
        }
        public void BajaEjemplar(string codigoInventario)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new BibliotecaDbContext()))
            {
                Ejemplar ejemplar = bUoW.RepositorioEjemplares.ObtenerPorCodInv(codigoInventario);

                ejemplar.FechaBaja = DateTime.Now;
                bUoW.Complete();
            }
        }
    }
}