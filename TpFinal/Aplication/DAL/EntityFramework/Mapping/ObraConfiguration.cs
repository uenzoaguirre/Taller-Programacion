using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aplication.DAL.EntityFramework.Mapping
{
    public class ObraConfiguration : IEntityTypeConfiguration<Obra>
    {
        public void Configure(EntityTypeBuilder<Obra> builder)
        {
            builder.HasKey(pObra => pObra.Id);

            builder.Property(pObra => pObra.Id).ValueGeneratedOnAdd();

            builder.Property(pObra => pObra.Titulo)
                .IsRequired();

            builder.Property(pObra => pObra.Lccn)
                .IsRequired();

            builder.Property(pObra => pObra.Descripcion)
                .IsRequired();

        }

    }
}