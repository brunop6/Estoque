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
    public partial class ConsultaFunc : Form
    {
        public ConsultaFunc()
        {
            InitializeComponent();
            PreencherLVFunc(1);
        }
        public void PreencherLVFunc(int opt) //opt 1 = Todos func | opt 2 = Consulta por nome
        {
            var funcDAO = new Model.FuncionarioDAO();
            SqlDataReader dr = funcDAO.RetornarFuncionarios();
            listView1.Items.Clear();
            switch (opt)
            {
                case 2:
                    dr.Close();
                    dr = funcDAO.ConsultarFunc(textBoxConsulta.Text);
                    break;
            }
            if (dr != null)
            {
                while (dr.Read())
                {
                    ListViewItem listView = new ListViewItem(dr.GetInt32(0).ToString());
                    listView.SubItems.Add(dr.GetString(1));
                    listView.SubItems.Add(dr.GetString(3));
                    if (dr.GetString(4) != "(00)-00000-0000")
                    {
                        listView.SubItems.Add(dr.GetString(4));
                    }
                    else
                    {
                        listView.SubItems.Add("");
                    }
                    listView1.Items.Add(listView);
                }
            }
            else
            {
                MessageBox.Show("Busca sem resultados...");
            }
        }
        private void buttonBusca_Click(object sender, EventArgs e)
        {
            PreencherLVFunc(2);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
