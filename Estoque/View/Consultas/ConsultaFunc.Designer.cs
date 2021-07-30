
namespace Estoque.View
{
    partial class ConsultaFunc
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBusca = new System.Windows.Forms.Button();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.columnContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnContato2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNome,
            this.columnContato,
            this.columnContato2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 450);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "Cod.";
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 305;
            // 
            // buttonBusca
            // 
            this.buttonBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.buttonBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.buttonBusca.Location = new System.Drawing.Point(244, 45);
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
            this.textBoxConsulta.Location = new System.Drawing.Point(19, 47);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(219, 20);
            this.textBoxConsulta.TabIndex = 5;
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(166)))), ((int)(((byte)(188)))));
            this.labelConsulta.Location = new System.Drawing.Point(13, 13);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(308, 31);
            this.labelConsulta.TabIndex = 4;
            this.labelConsulta.Text = "Consulta de Funcionário";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
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
            // columnContato
            // 
            this.columnContato.Text = "Contato";
            this.columnContato.Width = 199;
            // 
            // columnContato2
            // 
            this.columnContato2.Text = "Contato 2";
            this.columnContato2.Width = 238;
            // 
            // ConsultaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.labelConsulta);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(188, 25);
            this.Name = "ConsultaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsultaFunc";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ColumnHeader columnContato;
        private System.Windows.Forms.ColumnHeader columnContato2;
    }
}