using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplication.DAL.EntityFramework.Mapping
{
    public class EjemplarConfiguration : IEntityTypeConfiguration<Ejemplar>
    {
        public void Configure(EntityTypeBuilder<Ejemplar> builder)
        {
            builder.HasKey(pEjemplar => pEjemplar.Id);

            builder.Property(pEjemplar => pEjemplar.Id).ValueGeneratedOnAdd();

            builder.Property(pEjemplar => pEjemplar.CodigoInventario)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(pEjemplar => pEjemplar.FechaAlta)
                .IsRequired();

            builder.HasOne(pEjemplar => pEjemplar.Edicion);


        }

    }
}