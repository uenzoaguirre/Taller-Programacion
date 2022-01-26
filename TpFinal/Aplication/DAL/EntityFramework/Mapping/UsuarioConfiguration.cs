using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplication.DAL.EntityFramework.Mapping
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(pUsuario => pUsuario.Id);

            builder.Property(pUsuario => pUsuario.Id).ValueGeneratedOnAdd();

            builder.Property(pUsuario => pUsuario.NombreUsuario)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(pUsuario => pUsuario.Dni)
                .IsRequired();

            builder.Property(pUsuario => pUsuario.Password)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(pUsuario => pUsuario.Mail)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(pUsuario => pUsuario.FechaRegistro)
                .IsRequired();

            builder.Property(pUsuario => pUsuario.Puntaje)
                .IsRequired();

            builder.HasMany(pUsuario => pUsuario.Prestamos);

        }

    }
}