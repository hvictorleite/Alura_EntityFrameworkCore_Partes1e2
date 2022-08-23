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
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
                .ToTable("film");

            builder
                .Property(f => f.Id)
                .HasColumnName("film_id");

            builder
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("VARCHAR(255)")
                .IsRequired();

            builder
                .Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("TEXT");

            builder
                .Property(f => f.Duracao)
                .HasColumnName("length");

            builder
                .Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("VARCHAR(4)");

            builder
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("VARCHAR(45)")
                .IsRequired();

            // Shadow Properties
            // (Propriedade que não está declarada no modelo de negócio, porém
            // está modelada na tabela da entitade)
            //builder
            //    .Property<string>("rating")
            //    .HasColumnType("VARCHAR(10)");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
