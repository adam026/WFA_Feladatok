namespace UniMenes
{
    partial class FrmParkereso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSuly = new System.Windows.Forms.TextBox();
            this.tbFajta = new System.Windows.Forms.TextBox();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Súly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSuly);
            this.groupBox1.Controls.Add(this.tbFajta);
            this.groupBox1.Controls.Add(this.tbVaros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(698, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott unikornis tulajdonságai:";
            // 
            // tbSuly
            // 
            this.tbSuly.Enabled = false;
            this.tbSuly.Location = new System.Drawing.Point(519, 50);
            this.tbSuly.Name = "tbSuly";
            this.tbSuly.Size = new System.Drawing.Size(136, 26);
            this.tbSuly.TabIndex = 1;
            // 
            // tbFajta
            // 
            this.tbFajta.Enabled = false;
            this.tbFajta.Location = new System.Drawing.Point(302, 50);
            this.tbFajta.Name = "tbFajta";
            this.tbFajta.Size = new System.Drawing.Size(136, 26);
            this.tbFajta.TabIndex = 1;
            // 
            // tbVaros
            // 
            this.tbVaros.Enabled = false;
            this.tbVaros.Location = new System.Drawing.Point(83, 50);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(136, 26);
            this.tbVaros.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fajta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Város:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lehetséges párok:";
            // 
            // dgvPar
            // 
            this.dgvPar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fajta,
            this.Tulajdonos,
            this.Súly});
            this.dgvPar.Location = new System.Drawing.Point(16, 220);
            this.dgvPar.Name = "dgvPar";
            this.dgvPar.RowHeadersVisible = false;
            this.dgvPar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPar.Size = new System.Drawing.Size(695, 254);
            this.dgvPar.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Fajta
            // 
            this.Fajta.HeaderText = "Fajta";
            this.Fajta.Name = "Fajta";
            // 
            // Tulajdonos
            // 
            this.Tulajdonos.HeaderText = "Tulajdonos";
            this.Tulajdonos.Name = "Tulajdonos";
            // 
            // Súly
            // 
            this.Súly.HeaderText = "Súly";
            this.Súly.Name = "Súly";
            // 
            // FrmParkereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 486);
            this.Controls.Add(this.dgvPar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmParkereso";
            this.Text = "FrmParkereso";
            this.Load += new System.EventHandler(this.FrmParkereso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSuly;
        private System.Windows.Forms.TextBox tbFajta;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tulajdonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Súly;
    }
}