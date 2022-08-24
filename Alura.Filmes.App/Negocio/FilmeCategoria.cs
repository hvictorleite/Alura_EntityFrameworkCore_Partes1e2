using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class FilmeCategoria
    {
        // Classe Associativa
        // Para estabelecer relações entre 'Filme' e 'Categoria'
        public Filme Filme { get; set; }
        public Categoria Categoria { get; set; }
    }
}
