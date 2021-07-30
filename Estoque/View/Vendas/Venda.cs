using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estoque.View
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }
        public void ExecutarVenda()
        {
            var estoqueDAO = new Model.EstoqueDAO();
            var vendasDAO = new Model.VendasDAO();
            SqlDataReader dr;

            dr = estoqueDAO.ConsultarId(Convert.ToInt32(numericCodProd.Value));
            if (dr != null)
            {
                DialogResult result;
                int id = 0;
                string prod = null;
                int quant = 0;
                string tam = null;
                double valor = 0;
                string dia, diaDesc;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    prod = dr.GetString(1);
                    tam = dr.GetString(2);
                    quant = dr.GetInt32(3);
                    valor = dr.GetDouble(4);
                }
                dr.Close();
                /*
                 *Cod. Produto: 
                 *Produto..........:
                 *Tamanho..........:
                 *Valor..............:
                 */
                string msg = "Cod. Produto:  " + id + "\nProduto.........: " + prod + "\nTamanho........: " + tam + "\nValor...............: R$" + valor;
                result = MessageBox.Show(msg, "Confirmação de Venda", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    msg = estoqueDAO.Vender(id, Convert.ToInt32(numericQuant.Value), quant);
                    dia = dateTimePicker1.Value.ToShortDateString();
                    diaDesc = dia.Substring(6, 4) + dia.Substring(2, 4) + dia.Substring(0, 2);
                    var vendas = new Model.Vendas(Convert.ToInt32(numericFunc.Value), Convert.ToInt32(numericCodProd.Value), Convert.ToInt32(numericQuant.Value), diaDesc);

                    if (vendasDAO.Vender(vendas) != "0")
                    {
                        msg = vendasDAO.Vender(vendas);
                    }
                    MessageBox.Show(msg);
                    this.Close();
                }
            }
        }
        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            ExecutarVenda();
        }
    }
}
