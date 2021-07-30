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

namespace Estoque.View.Funcionarios
{
    public partial class LoginFunc : Form
    {
        public LoginFunc()
        {
            InitializeComponent();
            textBoxSenha.UseSystemPasswordChar = true;
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxSenha.UseSystemPasswordChar == true)
            {
                textBoxSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxSenha.UseSystemPasswordChar = true;
            }
        }
        public void AutenticarFunc()
        {
            if (numericCod.Value > 0 && textBoxSenha.Text.Length >= 3)
            {
                SqlDataReader dr;
                var funcDAO = new Model.FuncionarioDAO();

                dr = funcDAO.AutenticarFunc(Convert.ToInt32(numericCod.Value), textBoxSenha.Text);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        var dadosFunc = new DadosFunc(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4));
                        dadosFunc.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Código e/ou senha incorreto(s)!");
                    numericCod.Value = 0;
                    textBoxSenha.Clear();
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AutenticarFunc();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
