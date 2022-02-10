using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplication.DAL.EntityFramework.Mapping;


namespace Aplication.DAL.EntityFramework
{
    public class BibliotecaDbContext : DbContext
    {
        public DbSet<Ejemplar> Ejemplares { get; set; }
        public DbSet<Obra> Orbras { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cambiamos el nombre de la tabla//
            modelBuilder.Entity<Obra>().ToTable("Obras");
            modelBuilder.Entity<Edicion>().ToTable("Ediciones");
            modelBuilder.ApplyConfiguration(new EjemplarConfiguration());
            modelBuilder.ApplyConfiguration(new EdicionConfiguration());
            modelBuilder.ApplyConfiguration(new ObraConfiguration());
            modelBuilder.ApplyConfiguration(new PrestamoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=motty.db.elephantsql.com;Port=5432;Database=zqzvknse;Username=zqzvknse;Password=6FafZ0KQtMl0ra9QCvw5Ii8G3S47wWi2");
        }

    }
}