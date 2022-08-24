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
    class FilmeCategoriaConfiguration : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder
                .ToTable("film_category");

            // Shadow Properties

            builder
                .Property<int>("film_id")
                .IsRequired();
            
            builder
                .Property<byte>("category_id")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            // Criando chave primária

            builder
                .HasKey("film_id", "category_id");

            // Criando chave estrangeira

            builder
                .HasOne(fc => fc.Filme)
                .WithMany(f => f.Categorias)
                .HasForeignKey("film_id");

            builder
                .HasOne(fc => fc.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey("category_id");
        }
    }
}
