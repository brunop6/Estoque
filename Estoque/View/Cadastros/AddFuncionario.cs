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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
            textBoxSenha.UseSystemPasswordChar = true;
            textBoxConfirmSenha.UseSystemPasswordChar = true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (textBoxSenha.Text == textBoxConfirmSenha.Text)
            {
                if (maskedTextBoxContato2.Text == "(  )-     -")
                {
                    maskedTextBoxContato2.Text = "(00)-00000-0000";
                }
                var funcionario = new Model.Funcionario(1, textBoxNome.Text, textBoxSenha.Text, maskedTextBoxContato.Text, maskedTextBoxContato2.Text);
                var funcDAO = new Model.FuncionarioDAO();

                msg = funcDAO.CadastrarFunc(funcionario);
            }
            else
            {
                MessageBox.Show("O campo \"Senha\" e \"Confirmar senha\" devem ser iguais!");
            }         
            MessageBox.Show(msg);
            if (msg != null)
            {
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void checkBoxConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxConfirmSenha.UseSystemPasswordChar == true)
            {
                textBoxConfirmSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxConfirmSenha.UseSystemPasswordChar = true;
            }
        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
