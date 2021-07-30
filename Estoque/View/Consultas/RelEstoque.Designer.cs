
namespace Estoque.View
{
    partial class RelEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelEstoque));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEditItem = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelItemSelc = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxTam = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.labelTam = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.columnQuantMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.numericQuantMin = new System.Windows.Forms.NumericUpDown();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnProduto,
            this.columnTamanho,
            this.columnQuantidade,
            this.columnValor,
            this.columnQuantMin});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 519);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "Cod.";
            // 
            // columnProduto
            // 
            this.columnProduto.Text = "Produto";
            this.columnProduto.Width = 293;
            // 
            // columnTamanho
            // 
            this.columnTamanho.Text = "Tam.";
            this.columnTamanho.Width = 87;
            // 
            // columnQuantidade
            // 
            this.columnQuantidade.Text = "Quantidade";
            this.columnQuantidade.Width = 122;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 102;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Location = new System.Drawing.Point(651, 81);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(31, 23);
            this.buttonAtualizar.TabIndex = 4;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonBusca
            // 
            this.buttonBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonBusca.Location = new System.Drawing.Point(237, 79);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(64, 23);
            this.buttonBusca.TabIndex = 6;
            this.buttonBusca.Text = "Buscar";
            this.buttonBusca.UseVisualStyleBackColor = false;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxConsulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.textBoxConsulta.Location = new System.Drawing.Point(12, 81);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(219, 20);
            this.textBoxConsulta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(150)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta Estoque";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonReturn.Location = new System.Drawing.Point(996, 635);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Retornar";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericQuant);
            this.panel1.Controls.Add(this.numericQuantMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelEditItem);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelItemSelc);
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.textBoxProduto);
            this.panel1.Controls.Add(this.textBoxTam);
            this.panel1.Controls.Add(this.labelValor);
            this.panel1.Controls.Add(this.labelQuant);
            this.panel1.Controls.Add(this.labelTam);
            this.panel1.Controls.Add(this.labelProduto);
            this.panel1.Location = new System.Drawing.Point(721, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 317);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // labelEditItem
            // 
            this.labelEditItem.AutoSize = true;
            this.labelEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(174)))));
            this.labelEditItem.Location = new System.Drawing.Point(19, 25);
            this.labelEditItem.Name = "labelEditItem";
            this.labelEditItem.Size = new System.Drawing.Size(118, 26);
            this.labelEditItem.TabIndex = 24;
            this.labelEditItem.Text = "Editar Item";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonExcluir.Location = new System.Drawing.Point(175, 289);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 23;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(123, 72);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 22;
            // 
            // labelItemSelc
            // 
            this.labelItemSelc.AutoSize = true;
            this.labelItemSelc.Location = new System.Drawing.Point(21, 72);
            this.labelItemSelc.Name = "labelItemSelc";
            this.labelItemSelc.Size = new System.Drawing.Size(95, 13);
            this.labelItemSelc.TabIndex = 21;
            this.labelItemSelc.Text = "Item Selecionado: ";
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.textBoxValor.Location = new System.Drawing.Point(93, 195);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 20;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonCancel.Location = new System.Drawing.Point(256, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonSalvar.Location = new System.Drawing.Point(94, 289);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 18;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.textBoxProduto.Location = new System.Drawing.Point(93, 119);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(238, 20);
            this.textBoxProduto.TabIndex = 12;
            // 
            // textBoxTam
            // 
            this.textBoxTam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.textBoxTam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.textBoxTam.Location = new System.Drawing.Point(93, 142);
            this.textBoxTam.Name = "textBoxTam";
            this.textBoxTam.Size = new System.Drawing.Size(100, 20);
            this.textBoxTam.TabIndex = 14;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(21, 195);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 17;
            this.labelValor.Text = "Valor:";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(21, 168);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(65, 13);
            this.labelQuant.TabIndex = 15;
            this.labelQuant.Text = "Quantidade:";
            // 
            // labelTam
            // 
            this.labelTam.AutoSize = true;
            this.labelTam.Location = new System.Drawing.Point(21, 142);
            this.labelTam.Name = "labelTam";
            this.labelTam.Size = new System.Drawing.Size(55, 13);
            this.labelTam.TabIndex = 13;
            this.labelTam.Text = "Tamanho:";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(21, 119);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(47, 13);
            this.labelProduto.TabIndex = 11;
            this.labelProduto.Text = "Produto:";
            // 
            // columnQuantMin
            // 
            this.columnQuantMin.Text = "Quant.Min.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quant. Min.:";
            // 
            // numericQuantMin
            // 
            this.numericQuantMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numericQuantMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericQuantMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.numericQuantMin.Location = new System.Drawing.Point(93, 221);
            this.numericQuantMin.Name = "numericQuantMin";
            this.numericQuantMin.Size = new System.Drawing.Size(120, 20);
            this.numericQuantMin.TabIndex = 26;
            // 
            // numericQuant
            // 
            this.numericQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numericQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.numericQuant.Location = new System.Drawing.Point(92, 166);
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(120, 20);
            this.numericQuant.TabIndex = 27;
            // 
            // RelEstoque
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(188, 25);
            this.Name = "RelEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta Estoque";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnProduto;
        private System.Windows.Forms.ColumnHeader columnTamanho;
        private System.Windows.Forms.ColumnHeader columnQuantidade;
        private System.Windows.Forms.ColumnHeader columnValor;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelItemSelc;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.TextBox textBoxTam;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label labelTam;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelEditItem;
        private System.Windows.Forms.ColumnHeader columnQuantMin;
        private System.Windows.Forms.NumericUpDown numericQuant;
        private System.Windows.Forms.NumericUpDown numericQuantMin;
        private System.Windows.Forms.Label label2;
    }
}