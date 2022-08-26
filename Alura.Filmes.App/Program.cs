using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
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

            // SELECT com JOIN de Idiomas que estão como Idiomas Falados em filmes
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    var idiomas = contexto.Idiomas
            //        .Include(i => i.FilmesFalados);

            //    foreach (var idioma in idiomas)
            //    {
            //        Console.WriteLine(idioma);

            //        foreach(var filme in idioma.FilmesFalados)
            //        {
            //            Console.WriteLine(filme);
            //        }
            //        Console.WriteLine("\n");
            //    }
            //}


            // SELECT com JOIN de Filmes e seus idiomas falados
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    var filmes = contexto.Filmes
            //        .Include(f => f.IdiomaFalado);

            //    foreach (var filme in filmes)
            //    {
            //        Console.WriteLine(filme);
            //        Console.WriteLine(filme.IdiomaFalado);
            //    }
            //}

            //using (var contexto  = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    var livre = ClassificacaoIndicativa.Livre;
            //    string textoLivre = livre.paraString();

            //    var idioma = new Idioma() { Nome = "English" };

            //    var filme = new Filme();
            //    filme.Titulo = "O Senhor do Anéis";
            //    filme.Duracao = 120;
            //    filme.AnoLancamento = "2000";
            //    filme.Classificacao = ClassificacaoIndicativa.Livre;
            //    filme.IdiomaFalado = idioma;

            //    // LEMBRE-SE:
            //    // O Entity Framework não tem uma solução nativa para estabelecer
            //    // 'checks' para um campo, todavia aceita que sejam enviados
            //    // comandos SQL junto a uma Migration. Como exemplo do que
            //    // deve ser feito nestes casos, temos:
            //    // (dentro do método 'Up' da Migration) ->
            //    // var comandoSql = ALTER TABLE [dbo].[film]
            //    //      ADD CONSTRAINT[check_rating] CHECK(
            //    //          [rating] = 'NC-17' OR
            //    //          [rating] = 'R' OR
            //    //          [rating] = 'PG-13' OR
            //    //          [rating] = 'PG' OR
            //    //          [rating] = 'G');
            //    // migrationBuilder.comandoSql(sql);
            //    // (dentro do método 'Down' da Migration)
            //    // migrationBuilder.Sql("ALTER TABLE [dbo].[film]
            //    //      DROP CONSTRAINT[check_rating]");
            //}

            // SELECT na tabela de 'Cliente' e 'Funcionario'
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    foreach (var cliente in contexto.Clientes)
            //    {
            //        Console.WriteLine(cliente);
            //    }

            //    foreach (var funcionario in contexto.Funcionarios)
            //    {
            //        Console.WriteLine(funcionario);
            //    }
            //}

            //SELECTs Complexos -Relatório
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    Relação entre 'Ator' e 'FilmeAtor'
            //     Obtendo os cinco atores que mais atuaram em filmes
            //     Fazendo somente pelo Entity Framework Core
            //    var atoresMaisAtuantes = contexto.Atores
            //        .Include(a => a.Filmografia)
            //        .OrderByDescending(a => a.Filmografia.Count)
            //        .Take(5);

            //    Fazendo com linguagem SQL
            //     utilizando o método 'FromSql()' do EF Core
            //     OBS: Ver as limitações do método 'FromSql()' na documentação do EF
            //    var sql =
            //        @"SELECT a.* FROM actor a
            //            INNER JOIN 
            //                (SELECT TOP 5
            //                    a.actor_id COUNT(*) AS total
            //                    FROM actor a
            //                    INNER JOIN film_actor fa
            //                        ON fa.actor_id = a.actor_id
            //                GROUP BY a.actor_id
            //                ORDER BY total DESC) filmes
            //            ON filmes.actor_id = a.actor_id";
            //    var atoresMaisAtuantes =
            //        contexto.Atores.FromSql(sql)
            //            .Include(a => a.Filmografia);

            //    Segunda opção: Query SQL com View utilizando o 'FromSql()'
            //     OBS: O EF Core(pelo menos a versão 2.0) não suporta o uso de View,
            //         mas se a View já está declarada no BD, podemos utilizá - la através
            //          do 'FromSQL()'.No caso, utilizaremos a View 'top5_most_starred_actors'
            //    var sql =
            //        @"SELECT a.* FROM actor a
            //            INNER JOIN 
            //                top5_most_starred_actors filmes
            //            ON filmes.actor_id = a.actor_id";
            //    var atoresMaisAtuantes =
            //        contexto.Atores.FromSql(sql)
            //            .Include(a => a.Filmografia);


            //    // Os cinco filmes mais longos
            //    var filmesMaisLongos = 0;

            //    // Exibindo os top cinco atores com maior filmografia
            //    foreach (var ator in atoresMaisAtuantes)
            //    {
            //        Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes.");
            //    }

            //}

            // Executando 'Stored Procedures' no EF Core
            // para exibir atores que atuaram em filmes de uma determinada categoria
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();


                var categ = "Action"; // resposta esperada da consulta: 36

                var paramCateg = new SqlParameter("category_name", categ);
                var paramTotal = new SqlParameter
                {
                    ParameterName = "@total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };


                contexto.Database.ExecuteSqlCommand(
                    "EXECUTE total_actors_from_give_category @category_name @total_actors OUT", paramCateg, paramTotal);

                Console.WriteLine($"O total de atores na categoria {categ} é {paramTotal.Value}.");
            }
                 
        }
    }
}