using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplication.DAL.EntityFramework.Mapping
{
    public class PrestamoConfiguration : IEntityTypeConfiguration<Prestamo>
    {
        public void Configure(EntityTypeBuilder<Prestamo> builder)
        {
            builder.HasKey(pPrestamo => pPrestamo.Id);

            builder.Property(pPrestamo => pPrestamo.Id).ValueGeneratedOnAdd();

            builder.Property(pPrestamo => pPrestamo.FechaPrestamo)
                .IsRequired();

            builder.Property(pPrestamo => pPrestamo.FechaDevolucion);

            builder.Property(pPrestamo => pPrestamo.FechaVencimiento)
                .IsRequired();

            builder.HasOne(pPrestamo => pPrestamo.Solicitante);

            builder.HasOne(pPrestamo => pPrestamo.Ejemplar);
        }

    }
}