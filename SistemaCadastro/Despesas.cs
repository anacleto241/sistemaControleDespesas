using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Despesas
    {
        int DespesaID;
        int CategoriaID;
        string DescricaoDespesa;
        double Valor;

        public int DespesaID1 { get => DespesaID; set => DespesaID = value; }
        public int CategoriaID1 { get => CategoriaID; set => CategoriaID = value; }
        public string DescricaoDespesa1 { get => DescricaoDespesa; set => DescricaoDespesa = value; }
        public double Valor1 { get => Valor; set => Valor = value; }
    }
}
