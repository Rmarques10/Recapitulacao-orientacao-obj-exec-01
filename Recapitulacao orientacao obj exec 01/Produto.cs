using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulacao_orientacao_obj_exec_01
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoques()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProtudo(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProtudo(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total:"
                + ValorTotalEmEstoques().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
