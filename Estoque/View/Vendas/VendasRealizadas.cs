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

namespace Estoque.View.Vendas
{
    public partial class VendasRealizadas : Form
    {
        public VendasRealizadas()
        {
            InitializeComponent();
            PreencherLVVendas();
            PreencherComboBoxFunc();
        }
        public void PreencherLVVendas()
        {
            listView1.Items.Clear();

            string diaInicial, diaFinal, diaInicialDesc, diaFinalDesc, dataAsc;
            var vendasDAO = new Model.VendasDAO();
            SqlDataReader dr;

            diaInicial = dateTimePicker1.Value.ToShortDateString();
            diaInicialDesc = diaInicial.Substring(6, 4) + diaInicial.Substring(2, 4) + diaInicial.Substring(0, 2);
            diaFinal = dateTimePicker2.Value.ToShortDateString();
            diaFinalDesc = diaFinal.Substring(6, 4) + diaFinal.Substring(2, 4) + diaFinal.Substring(0, 2);

            dr = vendasDAO.PesquisarVendas(diaInicialDesc, diaFinalDesc, comboBoxFunc.Text, comboBoxOrderBy.Text, comboBoxSentido.Text);

            if(dr != null)
            {
                while (dr.Read())
                {
                    dataAsc = dr.GetString(5).Substring(8, 2)+ dr.GetString(5).Substring(4, 4) + dr.GetString(5).Substring(0, 4);

                    ListViewItem listView = new ListViewItem(dr.GetInt32(0).ToString());
                    listView.SubItems.Add(dr.GetString(1));
                    listView.SubItems.Add(dr.GetString(2));
                    listView.SubItems.Add(dr.GetInt32(3).ToString());
                    listView.SubItems.Add("R$"+dr.GetDouble(4).ToString());
                    listView.SubItems.Add(dataAsc);
                    listView1.Items.Add(listView);
                }
            }
            else
            {
                MessageBox.Show("Busca sem resultados...");
            }
        }
        public void PreencherComboBoxFunc()
        {
            var funcionarioDAO = new Model.FuncionarioDAO();
            SqlDataReader dr;

            dr = funcionarioDAO.RetornarFuncionarios();

            if (dr!=null)
            {
                while (dr.Read())
                {
                    comboBoxFunc.Items.Add(dr.GetString(1));
                }
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PreencherLVVendas();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
