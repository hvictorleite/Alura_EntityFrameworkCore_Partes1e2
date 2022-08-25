using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public short Duracao { get; set; }
        public string AnoLancamento { get; set; }
        public string TextoClassificacao { get; private set; }
        public ClassificacaoIndicativa Classificacao
        {
            get { return TextoClassificacao.paraValor(); }
            set { TextoClassificacao = value.paraString(); }
        }
        public IList<FilmeAtor> Elenco { get; set; }
        public IList<FilmeCategoria> Categorias { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }

        public Filme()
        {
            Elenco = new List<FilmeAtor>();
            Categorias = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"Filme ({Id}): {Titulo} - {AnoLancamento}" +
                $"\nDuração: {Duracao} min" +
                $"\nDescrição: {Descricao}";
        }
    }
}
