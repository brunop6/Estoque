using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Estoque
    {
        public int id { get; }
        public string produto { get; set; }
        public string tamanho { get; set; }
        public int quantidade { get; set; }
        public double valor { get; set; }
        public int quantMin { get; set; }

        public Estoque(int id, string produto, string tamanho, int quantidade, double valor, int quantMin)
        {
            this.id = id;
            this.produto = produto;
            this.tamanho = tamanho;
            this.quantidade = quantidade;
            this.valor = valor;
            this.quantMin = quantMin;
        }
    }
}
