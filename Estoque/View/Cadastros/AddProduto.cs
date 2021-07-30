using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.View
{
    public partial class AddProduto : Form
    {
        public AddProduto()
        {
            InitializeComponent();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string msg;
            if (textBoxProduto.TextLength > 0 && textBoxValor.TextLength>0 && numericQuant.Value>0)
            {
                Model.Estoque estoque = new Model.Estoque(0, textBoxProduto.Text, textBoxTam.Text, Convert.ToInt32(numericQuant.Value), Convert.ToDouble(textBoxValor.Text), Convert.ToInt32(numericQuantMin.Value));
                Model.EstoqueDAO estoqueDAO = new Model.EstoqueDAO();
                msg = estoqueDAO.AddProduto(estoque);
                textBoxProduto.Clear();
                textBoxTam.Clear();
                textBoxValor.Clear();
                numericQuant.Value = 1;
                numericQuantMin.Value = 1;
            }
            else
            {
                msg = "Preencha todos os campos!";
            }
            MessageBox.Show(msg);
            if(msg != "Preencha todos os campos!")
            {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
