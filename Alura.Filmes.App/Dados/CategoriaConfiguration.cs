using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
                .ToTable("category");

            builder
                .Property(c => c.Id)
                .HasColumnName("category_id");

            builder
                .Property(c => c.Nome)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(25)")
                .IsRequired();

            // Shadow Property
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
        }
    }
}
