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
    public partial class RelEstoque : Form
    {
        public RelEstoque()
        {
            InitializeComponent();
            PreencherListView();
        }
        public void PreencherListView()
        {
            listView1.Items.Clear();

            SqlDataReader dr;
            Model.EstoqueDAO estoqueDAO = new Model.EstoqueDAO();
            dr = estoqueDAO.RetornarEstoque();

            if(dr != null)
            {
                while (dr.Read())
                {
                    ListViewItem listView = new ListViewItem(dr.GetInt32(0).ToString());
                    listView.SubItems.Add(dr.GetString(1));
                    listView.SubItems.Add(dr.GetString(2));
                    listView.SubItems.Add(dr.GetInt32(3).ToString());
                    listView.SubItems.Add("R$"+dr.GetDouble(4).ToString());
                    listView.SubItems.Add(dr.GetInt32(5).ToString());
                    listView1.Items.Add(listView);
                }
            }
            else
            {
                MessageBox.Show("Busca sem resultados...");
            }
        }
        public void PreencherLVConsulta()
        {
            listView1.Items.Clear();

            Model.EstoqueDAO estoqueDAO = new Model.EstoqueDAO();
            SqlDataReader dr;

            dr = estoqueDAO.ConsultarProduto(textBoxConsulta.Text);
            if (dr != null)
            {
                while (dr.Read())
                {
                    ListViewItem listView = new ListViewItem(dr.GetInt32(0).ToString());
                    listView.SubItems.Add(dr.GetString(1));
                    listView.SubItems.Add(dr.GetString(2));
                    listView.SubItems.Add(dr.GetInt32(3).ToString());
                    listView.SubItems.Add("R$" + dr.GetDouble(4).ToString());
                    listView.SubItems.Add(dr.GetInt32(5).ToString());
                    listView1.Items.Add(listView);
                }
            }
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = null;
                string prod;
                string tam;
                int quant, quantMin;
                double valor;

                item = listView1.SelectedItems[0];
                prod = item.SubItems[1].Text;
                tam = item.SubItems[2].Text;
                quant = Convert.ToInt32(item.SubItems[3].Text);
                valor = Convert.ToDouble(item.SubItems[4].Text.Substring(2));
                quantMin = Convert.ToInt32(item.SubItems[5].Text);

                EditEstoque(Convert.ToInt32(item.Text), prod, tam, quant, valor, quantMin);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            PreencherListView();
        }
        private void buttonBusca_Click(object sender, EventArgs e)
        {
            if (textBoxConsulta.Text.Length == 0)
            {
                MessageBox.Show("Informe o texto a ser buscado...");
            }
            else
            {
                PreencherLVConsulta();
                textBoxConsulta.Clear();
            }
        }
        public void EditEstoque(int id, string produto, string tamanho, int quant, double valor, int quantMin)
        {
            labelID.Text = id.ToString();
            textBoxProduto.Text = produto;
            textBoxTam.Text = tamanho;
            numericQuant.Value = quant;
            textBoxValor.Text = "R$" + Convert.ToDouble(valor);
            numericQuantMin.Value = quantMin;
            panel1.Visible = true;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var estoque = new Model.Estoque(Convert.ToInt32(labelID.Text), textBoxProduto.Text, textBoxTam.Text, Convert.ToInt32(numericQuant.Value), Convert.ToDouble(textBoxValor.Text.Substring(2)), Convert.ToInt32(numericQuantMin.Value));
            var estoqueDAO = new Model.EstoqueDAO();
            MessageBox.Show(estoqueDAO.EditarEstoque(estoque));
            panel1.Visible = false;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja excluir o item selecionado?", "Excluir Item", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var estoqueDAO = new Model.EstoqueDAO();
                string msg;

                msg = estoqueDAO.ExcluirItem(Convert.ToInt32(labelID.Text));
                MessageBox.Show(msg);
                panel1.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
