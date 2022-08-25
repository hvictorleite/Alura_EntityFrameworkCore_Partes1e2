using Alura.Filmes.App.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Extensions
{
    public static class ClassificacaoIndicativaExtensions
    {
        private static Dictionary<string, ClassificacaoIndicativa> mapa = new Dictionary<string, ClassificacaoIndicativa>();

        public static string paraString(this ClassificacaoIndicativa valor)
        {
            return mapa.First(ci => ci.Value == valor).Key;
        }

        public static ClassificacaoIndicativa paraValor(this string texto)
        {
            return mapa.First(ci => ci.Key == texto).Value;
        }

    }
}
