using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Vendas
    {
        public int funcionarioID { get; set; }
        public int estoqueID { get; set; } 
        public int quantVendida { get; set; }
        public string dia { get; set; }

        public Vendas(int funcionarioID, int estoqueID, int quantVendida, string dia)
        {
            this.funcionarioID = funcionarioID;
            this.estoqueID = estoqueID;
            this.quantVendida = quantVendida;
            this.dia = dia;
        }
    }
}
