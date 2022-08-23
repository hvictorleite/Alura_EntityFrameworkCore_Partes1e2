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
        public DbSet<FilmeAtor> FilmesAtores { get; set; }

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
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            // -------------------------------


            // Configurando Entidade 'Filme'
            // ------------------------------
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            // ------------------------------

            // Configurando Entidade 'FilmeAtor'
            // ------------------------------
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            // ------------------------------
        }
    }
}
