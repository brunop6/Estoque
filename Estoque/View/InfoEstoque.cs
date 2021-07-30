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

namespace Estoque.View.Consultas
{
    public partial class InfoEstoque : Form
    {
        public InfoEstoque()
        {
            InitializeComponent();
            PreencherLabels();
            PreencherMaisVendidos();
            PreencherValorDia();
            PreencherVendasDia();
        }
        public void PreencherLabels()
        {
            SqlDataReader dr;
            var estoqueDAO = new Model.EstoqueDAO();
            int i = 0;

            dr = estoqueDAO.RetornarProdEmFalta();
            while (dr.Read())
            {
                i++;
            }
            labelItensEmFalta.Text = i.ToString();
            dr.Close();

            dr = estoqueDAO.RetornarTotal();
            while (dr.Read())
            {
                labelValorTotal.Text = "R$" + dr.GetValue(0).ToString();
            }
            dr.Close();

            dr = estoqueDAO.RetornarCountProdutos();
            while (dr.Read())
            {
                labelCountProd.Text = dr.GetInt32(0).ToString();
            }
            dr.Close();
        }
        public void PreencherMaisVendidos()
        {
            SqlDataReader dr;
            var estoqueDAO = new Model.EstoqueDAO();
            string diaInicial, diaFinal, diaInicialDesc, diaFinalDesc;
            int i = 1;

            diaInicial = dateTimePicker1.Value.ToShortDateString();
            diaInicialDesc = diaInicial.Substring(6, 4) + diaInicial.Substring(2, 4) + diaInicial.Substring(0, 2);
            diaFinal = dateTimePicker2.Value.ToShortDateString();
            diaFinalDesc = diaFinal.Substring(6, 4) + diaFinal.Substring(2, 4) + diaFinal.Substring(0, 2);


            dr = estoqueDAO.RetornarMaisVendidos(diaInicialDesc, diaFinalDesc);
            if (dr != null)
            {
                chart1.Series[0].Points.Clear();
                while (dr.Read() && i <= 5)
                {
                    chart1.Series[0].Points.AddXY(i + "º", dr.GetInt32(2));
                    if (chart1.Series.IsUniqueName(dr.GetString(1)))
                    {
                        chart1.Series.Add(dr.GetString(1));
                    }     
                    i++;
                }
            }
            
        }
        public void PreencherVendasDia()
        {
            SqlDataReader dr;
            var vendasDAO = new Model.VendasDAO();
            string dia, diaDesc;
            int i = 0;

            dia = dateTimePicker2.Value.ToShortDateString();
            diaDesc = dia.Substring(6, 4) + dia.Substring(2, 4) + dia.Substring(0, 2);
            dr = vendasDAO.RetornarVendasDia(diaDesc);

            chart2.Series[0].Points.Clear();
            if (dr != null)
            {
                while (dr.Read())
                {
                    chart2.Series[0].Points.AddXY(dr.GetString(1), dr.GetDouble(2));
                    i++;
                }
            }
            else
            {
                chart2.Series[0].Points.AddXY("Sem vendas registradas", 0);
            }
           
        }
        public void PreencherValorDia()
        {
            SqlDataReader dr;
            var vendasDAO = new Model.VendasDAO();
            int i = 1;
            string dataAsc;

            dr = vendasDAO.RetornarValorDia();
            if (dr != null)
            {
                chart3.Series[0].Points.Clear();
                while (dr.Read() && i <= 5)
                {
                    dataAsc = dr.GetString(1).Substring(8, 2) + dr.GetString(1).Substring(4, 4) + dr.GetString(1).Substring(0, 4);
                    chart3.Series[0].Points.AddXY(dataAsc, dr.GetDouble(0));
                    i++;
                }
            }
            
        }

        private void realizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var venda = new Venda();
            venda.Show();
        }

        private void vendasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendasRealizadas = new Vendas.VendasRealizadas();
            vendasRealizadas.Show();
        }

        private void funcionáriosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            funcionáriosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void funcionáriosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            funcionáriosToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void vendasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            vendasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void vendasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            vendasToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void dadosCadastraisToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            dadosCadastraisToolStripMenuItem.ForeColor = Color.Black;
        }

        private void dadosCadastraisToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            dadosCadastraisToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void realizarVendasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            realizarVendasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void realizarVendasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            realizarVendasToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void vendasRealizadasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            vendasRealizadasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void vendasRealizadasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            vendasRealizadasToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void cadastrarFuncionárioToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            cadastrarFuncionárioToolStripMenuItem1.ForeColor = Color.Black;
        }

        private void cadastrarFuncionárioToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            cadastrarFuncionárioToolStripMenuItem1.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void consultarFuncionárioToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            consultarFuncionárioToolStripMenuItem1.ForeColor = Color.Black;
        }

        private void consultarFuncionárioToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            consultarFuncionárioToolStripMenuItem1.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void produtosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            produtosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void produtosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            produtosToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void cadastrarProdutosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            cadastrarProdutosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void cadastrarProdutosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            cadastrarProdutosToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void consultarProdutoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            consultarProdutoToolStripMenuItem.ForeColor = Color.Black;
        }

        private void consultarProdutoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            consultarProdutoToolStripMenuItem.ForeColor = Color.FromArgb(209, 209, 209);
        }

        private void dadosCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginFunc = new Funcionarios.LoginFunc();
            loginFunc.Show();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            PreencherLabels();
            PreencherMaisVendidos();
            PreencherValorDia();
            PreencherVendasDia();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PreencherMaisVendidos();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto();
            addProduto.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFuncionario addFuncionario = new AddFuncionario();
            addFuncionario.Show();
        }

        private void consultarFuncionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFunc consultaFunc = new ConsultaFunc();
            consultaFunc.Show();
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relEstoque = new View.RelEstoque();
            relEstoque.Show();
        }
    }
}