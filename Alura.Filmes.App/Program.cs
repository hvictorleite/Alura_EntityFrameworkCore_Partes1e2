using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SELECT * FROM ATOR
            //using(var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();
            //    foreach(var item in contexto.Atores.ToList())
            //    {
            //        System.Console.WriteLine("Ator/Atriz: " + item.PrimeiroNome + " " + item.UltimoNome);
            //    }
            //}

            // INSERT INTO ...
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    var ator = new Ator();
            //    ator.PrimeiroNome = "Tom";
            //    ator.UltimoNome = "Hanks";

            //    contexto.Atores.Add(ator);

            //    contexto.SaveChanges();
            //}

            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    // Listar 10 atores modificados recentemente
            //    var atores = contexto.Atores
            //                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
            //                    .Take(10);

            //    foreach(var ator in atores)
            //    {
            //        Console.WriteLine(ator + " - "
            //            + contexto.Entry(ator).Property("last_update").CurrentValue);
            //    }

            //}

            // SELECT com JOIN entre 'Filme', 'FilmeAtor' e 'Ator'
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    var filme = contexto.Filmes
            //        .Include(f => f.Elenco)
            //        .ThenInclude(fa => fa.Ator)
            //        .First();

            //    Console.WriteLine(filme);
            //    Console.WriteLine("Elenco:");

            //    foreach (var ator in filme.Elenco)
            //    {
            //        Console.WriteLine(ator.Ator);
            //    }
            //}


            // SELECT com JOIN entre 'Filme', 'FilmeAtor' e 'Ator'
            //            using (var contexto = new AluraFilmesContexto())
            //            {
            //                contexto.LogSQLToConsole();

            //                // Lista de Filmes de todas as categorias
            //                var categorias = contexto.Categorias
            //                    .Include(c => c.Filmes)
            //                    .ThenInclude(fc => fc.Filme);
            //;
            //                Console.WriteLine("Categorias:");

            //                foreach (var categoria in categorias)
            //                {
            //                    Console.WriteLine("\nFilmes da " + categoria);

            //                    foreach(var fc in categoria.Filmes)
            //                    {
            //                        Console.WriteLine(fc.Filme);
            //                    }
            //                }

            //            }

            //using (var contexto = new AluraFilmesContexto())
            //{

            //    contexto.LogSQLToConsole();

            //    Lista de categorias do primeiro filme da lista
            //   var filme = contexto.Filmes
            //       .Include(f => f.Categorias)
            //       .ThenInclude(fc => fc.Categoria)
            //       .First();

            //    Console.WriteLine(filme);
            //    Console.WriteLine("Categorias:");

            //    foreach (var categoria in filme.Categorias)
            //    {
            //        Console.WriteLine(categoria.Categoria);
            //    }

            //}


            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                foreach(var idioma in contexto.Idiomas)
                {
                    Console.WriteLine(idioma);
                }
            }

        }
    }
}