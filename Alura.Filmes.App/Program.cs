using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SELECT * FROM ATOR
            using(var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();
                foreach(var item in contexto.Atores.ToList())
                {
                    System.Console.WriteLine("Ator/Atriz: " + item.PrimeiroNome + " " + item.UltimoNome);
                }
            }
        }
    }
}