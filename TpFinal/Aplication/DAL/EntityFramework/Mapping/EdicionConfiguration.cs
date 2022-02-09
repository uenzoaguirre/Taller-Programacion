using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplication.DAL.EntityFramework.Mapping
{
    public class EdicionConfiguration : IEntityTypeConfiguration<Edicion>
    {
        public void Configure(EntityTypeBuilder<Edicion> builder)
        {
            builder.HasKey(pEdicion => pEdicion.Id);

            builder.Property(pEdicion => pEdicion.Id).ValueGeneratedOnAdd();

            builder.Property(pEdicion => pEdicion.Isbn)
                .IsRequired();

            builder.Property(pEdicion => pEdicion.AñoEdicion);

            builder.Property(pEdicion => pEdicion.NumeroPaginas)
                .IsRequired();

            builder.Property(pEdicion => pEdicion.Portada)
                .IsRequired();

            builder.HasOne(pEdicion => pEdicion.Obra);

            builder.Property(pEdicion => pEdicion.FechaPublicacion)
                .IsRequired();
        }

    }
}