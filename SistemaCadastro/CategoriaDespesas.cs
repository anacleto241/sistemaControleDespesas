using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class CategoriaDespesas
    {
        int categoriaID;
        string nomeCategoria;
        string descricaoCategoria;

        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
        public string NomeCategoria { get => nomeCategoria; set => nomeCategoria = value; }
        public string DescricaoCategoria { get => descricaoCategoria; set => descricaoCategoria = value; }
    }
}
