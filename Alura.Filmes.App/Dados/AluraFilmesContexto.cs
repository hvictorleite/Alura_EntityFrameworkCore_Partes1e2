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

        // Configuração de conexão com o Banco de Dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Usando SQL Serve para o caminho e banco especificado
            optionsBuilder.UseSqlServer("Server=(localdb)mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

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
            // (Propriedade )
            modelBuilder.Entity<Ator>()
                .Property<DateTime>("last_update")
                .IsRequired();

            // -------------------------------


        }
    }
}
