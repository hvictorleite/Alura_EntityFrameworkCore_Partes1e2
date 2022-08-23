﻿using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder
                .ToTable("film_actor");

            // Shadow Properties
            builder
                .Property<int>("film_id")
                .IsRequired();

            builder
                .Property<int>("actor_id")
                .IsRequired();
            
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            // Configurando chave primaria
            builder
                .HasKey("film_id", "actor_id");

            // Configurando chaves estrangeiras
            builder
                .HasOne(fa => fa.Filme)
                .WithMany(f => f.Elenco)
                .HasForeignKey("film_id");

            builder
                .HasOne(fa => fa.Ator)
                .WithMany(a => a.Filmografia)
                .HasForeignKey("actor_id");
        }
    }
}
