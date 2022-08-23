﻿using Alura.Filmes.App.Dados;
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

            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                foreach (var item in contexto.FilmesAtores)
                {
                    var entidade = contexto.Entry(item);
                    var filme_id = entidade.Property("film_id").CurrentValue;
                    var ator_id = entidade.Property("actor_id").CurrentValue;
                    var last_upd = entidade.Property("last_update").CurrentValue;

                    Console.WriteLine($"Filme {filme_id}, Ator {ator_id}, Última Atualização: {last_upd}");
                }
            }

        }
    }
}