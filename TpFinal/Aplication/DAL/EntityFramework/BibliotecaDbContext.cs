using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Aplication.DAL.EntityFramework
{
    public class BibliotecaDbContext : DbContext
    {
        public DbSet<Ejemplar> Ejemplares { get; set}
        public DbSet<Obra> Orbras { get; set}
        public DbSet<Prestamo> Prestamos { get; set}
        public DbSet<Usuario> Usuarios { get; set}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AccountManagerNet5;Trusted_Connection=True;");
        }

    }
}