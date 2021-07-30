using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.View.Funcionarios
{
    public partial class DadosFunc : Form
    {
        public DadosFunc(int id, string nome, string senha, string contato, string contato2)
        {
            InitializeComponent();
            textBoxSenha.UseSystemPasswordChar = true;
            labelID.Text = id.ToString();
            textBoxNome.Text = nome;
            textBoxSenha.Text = senha;
            maskedTextBoxCont.Text = contato;
            maskedTextBoxCont2.Text = contato2;
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (buttonSalvar.Visible == false)
            {
                buttonCancel.Visible = true;
                buttonSalvar.Visible = true;
                textBoxNome.Enabled = true;
                textBoxSenha.Enabled = true;
                maskedTextBoxCont.Enabled = true;
                maskedTextBoxCont2.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel.Visible = false;
            buttonSalvar.Visible = false;
            textBoxNome.Enabled = false;
            textBoxSenha.Enabled = false;
            maskedTextBoxCont.Enabled = false;
            maskedTextBoxCont2.Enabled = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var funcDAO = new Model.FuncionarioDAO();
            string msg;

            msg = funcDAO.EditarFuncionario(Convert.ToInt32(labelID.Text), textBoxNome.Text, textBoxSenha.Text, maskedTextBoxCont.Text, maskedTextBoxCont2.Text);
            MessageBox.Show(msg);
            buttonCancel.Visible = false;
            buttonSalvar.Visible = false;
            textBoxNome.Enabled = false;
            textBoxSenha.Enabled = false;
            maskedTextBoxCont.Enabled = false;
            maskedTextBoxCont2.Enabled = false;
        }
    }
}
