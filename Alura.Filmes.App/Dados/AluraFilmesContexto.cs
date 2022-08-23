using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    class AluraFilmesContexto : DbContext
    {
        // Modelagem da Tabela actor no Banco de dados
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        // Configuração de conexão com o Banco de Dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Usando SQL Serve para o caminho e banco especificado
            optionsBuilder.UseSqlServer("Server=(localdb)mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando Entidade 'Ator'
            // ------------------------------   
            modelBuilder.Entity<Ator>().
                ToTable("actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("VARCHAR(45)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
                .Property(a => a.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("VARCHAR(45)")
                .IsRequired();

            // Shadow Properties
            // (Propriedade que não está declarada no modelo de negócio, porém
            // está modelada na tabela da entitade)
            modelBuilder.Entity<Ator>()
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            // -------------------------------


            // Configurando Entidade 'Ator'
            // ------------------------------
            modelBuilder.Entity<Filme>()
                .ToTable("film");

            modelBuilder.Entity<Filme>()
                .Property(f => f.Id)
                .HasColumnName("film_id");

            modelBuilder.Entity<Filme>()
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("VARCHAR(255)")
                .IsRequired();

            modelBuilder.Entity<Filme>()
                .Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("TEXT");

            modelBuilder.Entity<Filme>()
                .Property(f => f.Duracao)
                .HasColumnName("length");

            modelBuilder.Entity<Filme>()
                .Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("VARCHAR(4)");

            modelBuilder.Entity<Filme>()
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("VARCHAR(45)")
                .IsRequired();

            // Shadow Properties
            // (Propriedade que não está declarada no modelo de negócio, porém
            // está modelada na tabela da entitade)
            //modelBuilder.Entity<Filme>()
            //    .Property<string>("rating")
            //    .HasColumnType("VARCHAR(10)");

            modelBuilder.Entity<Filme>()
                .Property<DateTime>("last_update")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
            // ------------------------------
        }
    }
}
