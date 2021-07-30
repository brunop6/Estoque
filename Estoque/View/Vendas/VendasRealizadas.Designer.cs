
namespace Estoque.View.Vendas
{
    partial class VendasRealizadas
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
            this.labelVEndasReali = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelA = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFunc = new System.Windows.Forms.ComboBox();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxSentido = new System.Windows.Forms.ComboBox();
            this.labelSentido = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVEndasReali
            // 
            this.labelVEndasReali.AutoSize = true;
            this.labelVEndasReali.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVEndasReali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(199)))), ((int)(((byte)(242)))));
            this.labelVEndasReali.Location = new System.Drawing.Point(12, 9);
            this.labelVEndasReali.Name = "labelVEndasReali";
            this.labelVEndasReali.Size = new System.Drawing.Size(248, 31);
            this.labelVEndasReali.TabIndex = 0;
            this.labelVEndasReali.Text = "Vendas Realizadas";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(15, 60);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(63, 13);
            this.labelPeriodo.TabIndex = 1;
            this.labelPeriodo.Text = "Período: de";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 55);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(189, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(19, 13);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "à: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(214, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Funcionário: ";
            // 
            // comboBoxFunc
            // 
            this.comboBoxFunc.FormattingEnabled = true;
            this.comboBoxFunc.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxFunc.Location = new System.Drawing.Point(402, 55);
            this.comboBoxFunc.Name = "comboBoxFunc";
            this.comboBoxFunc.Size = new System.Drawing.Size(190, 21);
            this.comboBoxFunc.TabIndex = 6;
            this.comboBoxFunc.Text = "Todos";
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Location = new System.Drawing.Point(598, 60);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(69, 13);
            this.labelOrderBy.TabIndex = 7;
            this.labelOrderBy.Text = "Ordenar por: ";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Código",
            "Vendedor(a)",
            "Produto",
            "Quantidade",
            "Valor",
            "Data"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(673, 55);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(125, 21);
            this.comboBoxOrderBy.TabIndex = 8;
            this.comboBoxOrderBy.Text = "Código";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnVendedor,
            this.columnProduto,
            this.columnQuant,
            this.columnValor,
            this.columnData});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 545);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "Cod.";
            // 
            // columnVendedor
            // 
            this.columnVendedor.Text = "Vendedor(a)";
            this.columnVendedor.Width = 270;
            // 
            // columnProduto
            // 
            this.columnProduto.Text = "Produto";
            this.columnProduto.Width = 200;
            // 
            // columnQuant
            // 
            this.columnQuant.Text = "Quant.";
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 80;
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            this.columnData.Width = 120;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonBuscar.Location = new System.Drawing.Point(996, 55);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxSentido
            // 
            this.comboBoxSentido.FormattingEnabled = true;
            this.comboBoxSentido.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.comboBoxSentido.Location = new System.Drawing.Point(860, 55);
            this.comboBoxSentido.Name = "comboBoxSentido";
            this.comboBoxSentido.Size = new System.Drawing.Size(125, 21);
            this.comboBoxSentido.TabIndex = 12;
            this.comboBoxSentido.Text = "Crescente";
            // 
            // labelSentido
            // 
            this.labelSentido.AutoSize = true;
            this.labelSentido.Location = new System.Drawing.Point(804, 60);
            this.labelSentido.Name = "labelSentido";
            this.labelSentido.Size = new System.Drawing.Size(49, 13);
            this.labelSentido.TabIndex = 11;
            this.labelSentido.Text = "Sentido: ";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Location = new System.Drawing.Point(996, 635);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 13;
            this.buttonReturn.Text = "Retornar";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // VendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.comboBoxSentido);
            this.Controls.Add(this.labelSentido);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.labelOrderBy);
            this.Controls.Add(this.comboBoxFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelPeriodo);
            this.Controls.Add(this.labelVEndasReali);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(188, 25);
            this.Name = "VendasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VendasRealizadas";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVEndasReali;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFunc;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnVendedor;
        private System.Windows.Forms.ColumnHeader columnProduto;
        private System.Windows.Forms.ColumnHeader columnQuant;
        private System.Windows.Forms.ColumnHeader columnValor;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxSentido;
        private System.Windows.Forms.Label labelSentido;
        private System.Windows.Forms.Button buttonReturn;
    }
}