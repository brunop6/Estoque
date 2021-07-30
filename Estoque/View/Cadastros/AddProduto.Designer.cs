
namespace Estoque.View
{
    partial class AddProduto
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelICadastro = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxTam = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.labelTam = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            this.numericQuantMin = new System.Windows.Forms.NumericUpDown();
            this.labelQuantMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantMin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(109, 9);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 21;
            // 
            // labelICadastro
            // 
            this.labelICadastro.AutoSize = true;
            this.labelICadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.labelICadastro.Location = new System.Drawing.Point(7, 9);
            this.labelICadastro.Name = "labelICadastro";
            this.labelICadastro.Size = new System.Drawing.Size(236, 31);
            this.labelICadastro.TabIndex = 20;
            this.labelICadastro.Text = "Cadastrar Produto";
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textBoxValor.Location = new System.Drawing.Point(128, 152);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 26);
            this.textBoxValor.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(247, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 29);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Retornar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(104, 234);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(82, 29);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textBoxProduto.Location = new System.Drawing.Point(128, 56);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(243, 26);
            this.textBoxProduto.TabIndex = 1;
            // 
            // textBoxTam
            // 
            this.textBoxTam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxTam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textBoxTam.Location = new System.Drawing.Point(128, 88);
            this.textBoxTam.Name = "textBoxTam";
            this.textBoxTam.Size = new System.Drawing.Size(100, 26);
            this.textBoxTam.TabIndex = 2;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(7, 152);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(50, 20);
            this.labelValor.TabIndex = 16;
            this.labelValor.Text = "Valor:";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuant.Location = new System.Drawing.Point(7, 120);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(96, 20);
            this.labelQuant.TabIndex = 14;
            this.labelQuant.Text = "Quantidade:";
            // 
            // labelTam
            // 
            this.labelTam.AutoSize = true;
            this.labelTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTam.Location = new System.Drawing.Point(7, 88);
            this.labelTam.Name = "labelTam";
            this.labelTam.Size = new System.Drawing.Size(80, 20);
            this.labelTam.TabIndex = 12;
            this.labelTam.Text = "Tamanho:";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(7, 56);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(69, 20);
            this.labelProduto.TabIndex = 10;
            this.labelProduto.Text = "Produto:";
            // 
            // numericQuant
            // 
            this.numericQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numericQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.numericQuant.Location = new System.Drawing.Point(128, 120);
            this.numericQuant.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(100, 26);
            this.numericQuant.TabIndex = 3;
            this.numericQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericQuantMin
            // 
            this.numericQuantMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numericQuantMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericQuantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.numericQuantMin.Location = new System.Drawing.Point(128, 184);
            this.numericQuantMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericQuantMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantMin.Name = "numericQuantMin";
            this.numericQuantMin.Size = new System.Drawing.Size(100, 26);
            this.numericQuantMin.TabIndex = 22;
            this.numericQuantMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantMin
            // 
            this.labelQuantMin.AutoSize = true;
            this.labelQuantMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantMin.Location = new System.Drawing.Point(7, 184);
            this.labelQuantMin.Name = "labelQuantMin";
            this.labelQuantMin.Size = new System.Drawing.Size(115, 20);
            this.labelQuantMin.TabIndex = 23;
            this.labelQuantMin.Text = "Quant. Mínima:";
            // 
            // AddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.numericQuantMin);
            this.Controls.Add(this.labelQuantMin);
            this.Controls.Add(this.numericQuant);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelICadastro);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxTam);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelTam);
            this.Controls.Add(this.labelProduto);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(188, 25);
            this.Name = "AddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Produto";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelICadastro;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxTam;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label labelTam;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.NumericUpDown numericQuant;
        private System.Windows.Forms.NumericUpDown numericQuantMin;
        private System.Windows.Forms.Label labelQuantMin;
    }
}