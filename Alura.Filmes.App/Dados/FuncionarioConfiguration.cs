﻿using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);

            builder
                .ToTable("staff");

            builder
                .Property(f => f.Id)
                .HasColumnName("staff_id");

            builder
                .Property(f => f.Login)
                .HasColumnName("username")
                .HasColumnType("VARCHAR(16)")
                .IsRequired();

            builder
                .Property(f => f.Senha)
                .HasColumnName("password")
                .HasColumnType("VARCHAR(40)");
        }
    }
}