
namespace Estoque.View
{
    partial class AddFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFuncionario));
            this.labelCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmSenha = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.maskedTextBoxContato = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxContato2 = new System.Windows.Forms.MaskedTextBox();
            this.labelContato2 = new System.Windows.Forms.Label();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.checkBoxConfirm = new System.Windows.Forms.CheckBox();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(141)))), ((int)(((byte)(147)))));
            this.labelCadastro.Location = new System.Drawing.Point(54, 13);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(283, 31);
            this.labelCadastro.TabIndex = 0;
            this.labelCadastro.Text = "Cadastrar Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo:*";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(188, 60);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(219, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(59, 242);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 29);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(188, 92);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(219, 26);
            this.textBoxSenha.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(55, 92);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(66, 20);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha:*";
            // 
            // textBoxConfirmSenha
            // 
            this.textBoxConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmSenha.Location = new System.Drawing.Point(188, 124);
            this.textBoxConfirmSenha.Name = "textBoxConfirmSenha";
            this.textBoxConfirmSenha.Size = new System.Drawing.Size(219, 26);
            this.textBoxConfirmSenha.TabIndex = 6;
            // 
            // labelConfirmSenha
            // 
            this.labelConfirmSenha.AutoSize = true;
            this.labelConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmSenha.Location = new System.Drawing.Point(55, 124);
            this.labelConfirmSenha.Name = "labelConfirmSenha";
            this.labelConfirmSenha.Size = new System.Drawing.Size(136, 20);
            this.labelConfirmSenha.TabIndex = 7;
            this.labelConfirmSenha.Text = "Confirmar senha:*";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContato.Location = new System.Drawing.Point(55, 156);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(76, 20);
            this.labelContato.TabIndex = 9;
            this.labelContato.Text = "Contato:*";
            // 
            // maskedTextBoxContato
            // 
            this.maskedTextBoxContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxContato.Location = new System.Drawing.Point(188, 155);
            this.maskedTextBoxContato.Mask = "(00)-00000-0000";
            this.maskedTextBoxContato.Name = "maskedTextBoxContato";
            this.maskedTextBoxContato.Size = new System.Drawing.Size(219, 26);
            this.maskedTextBoxContato.TabIndex = 10;
            // 
            // maskedTextBoxContato2
            // 
            this.maskedTextBoxContato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxContato2.Location = new System.Drawing.Point(188, 187);
            this.maskedTextBoxContato2.Mask = "(00)-00000-0000";
            this.maskedTextBoxContato2.Name = "maskedTextBoxContato2";
            this.maskedTextBoxContato2.Size = new System.Drawing.Size(219, 26);
            this.maskedTextBoxContato2.TabIndex = 12;
            // 
            // labelContato2
            // 
            this.labelContato2.AutoSize = true;
            this.labelContato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContato2.Location = new System.Drawing.Point(55, 188);
            this.labelContato2.Name = "labelContato2";
            this.labelContato2.Size = new System.Drawing.Size(83, 20);
            this.labelContato2.TabIndex = 11;
            this.labelContato2.Text = "Contato 2:";
            // 
            // checkBoxSenha
            // 
            this.checkBoxSenha.AutoSize = true;
            this.checkBoxSenha.Location = new System.Drawing.Point(424, 101);
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.Size = new System.Drawing.Size(83, 17);
            this.checkBoxSenha.TabIndex = 13;
            this.checkBoxSenha.Text = "Exibir senha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            this.checkBoxSenha.CheckedChanged += new System.EventHandler(this.checkBoxSenha_CheckedChanged);
            // 
            // checkBoxConfirm
            // 
            this.checkBoxConfirm.AutoSize = true;
            this.checkBoxConfirm.Location = new System.Drawing.Point(424, 133);
            this.checkBoxConfirm.Name = "checkBoxConfirm";
            this.checkBoxConfirm.Size = new System.Drawing.Size(83, 17);
            this.checkBoxConfirm.TabIndex = 14;
            this.checkBoxConfirm.Text = "Exibir senha";
            this.checkBoxConfirm.UseVisualStyleBackColor = true;
            this.checkBoxConfirm.CheckedChanged += new System.EventHandler(this.checkBoxConfirm_CheckedChanged);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 15;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Click += new System.EventHandler(this.pictureBoxReturn_Click);
            // 
            // AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.checkBoxConfirm);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.maskedTextBoxContato2);
            this.Controls.Add(this.labelContato2);
            this.Controls.Add(this.maskedTextBoxContato);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.textBoxConfirmSenha);
            this.Controls.Add(this.labelConfirmSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCadastro);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(188, 25);
            this.Name = "AddFuncionario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Funcionario";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxConfirmSenha;
        private System.Windows.Forms.Label labelConfirmSenha;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContato;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContato2;
        private System.Windows.Forms.Label labelContato2;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private System.Windows.Forms.CheckBox checkBoxConfirm;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
    }
}