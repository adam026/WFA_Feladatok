namespace Utazasi_Iroda
{
    partial class frmUtasLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtasLista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUtasNeve = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUtvonal = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Kód = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Név = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cím = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÚtKód = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kezdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uticél = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUtasNeve);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés utas neve alapján:";
            // 
            // tbUtasNeve
            // 
            this.tbUtasNeve.Location = new System.Drawing.Point(7, 26);
            this.tbUtasNeve.Name = "tbUtasNeve";
            this.tbUtasNeve.Size = new System.Drawing.Size(317, 26);
            this.tbUtasNeve.TabIndex = 0;
            this.tbUtasNeve.TextChanged += new System.EventHandler(this.tbUtasNeve_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUtvonal);
            this.groupBox2.Location = new System.Drawing.Point(397, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szűrés túra útvonal célja alapján:";
            // 
            // tbUtvonal
            // 
            this.tbUtvonal.Location = new System.Drawing.Point(6, 25);
            this.tbUtvonal.Name = "tbUtvonal";
            this.tbUtvonal.Size = new System.Drawing.Size(302, 26);
            this.tbUtvonal.TabIndex = 0;
            this.tbUtvonal.TextChanged += new System.EventHandler(this.tbUtvonal_TextChanged);
            // 
            // dgvLista
            // 
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kód,
            this.Név,
            this.Cím,
            this.ÚtKód,
            this.Kezdes,
            this.Uticél});
            this.dgvLista.Location = new System.Drawing.Point(34, 140);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.Size = new System.Drawing.Size(677, 150);
            this.dgvLista.TabIndex = 2;
            // 
            // Kód
            // 
            this.Kód.HeaderText = "Kód";
            this.Kód.Name = "Kód";
            // 
            // Név
            // 
            this.Név.HeaderText = "Név";
            this.Név.Name = "Név";
            // 
            // Cím
            // 
            this.Cím.FillWeight = 110F;
            this.Cím.HeaderText = "Cím";
            this.Cím.Name = "Cím";
            // 
            // ÚtKód
            // 
            this.ÚtKód.FillWeight = 80F;
            this.ÚtKód.HeaderText = "Út Kód";
            this.ÚtKód.Name = "ÚtKód";
            // 
            // Kezdes
            // 
            this.Kezdes.HeaderText = "Kezdés";
            this.Kezdes.Name = "Kezdes";
            // 
            // Uticél
            // 
            this.Uticél.FillWeight = 110F;
            this.Uticél.HeaderText = "Uticél";
            this.Uticél.Name = "Uticél";
            // 
            // frmUtasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 407);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUtasLista";
            this.Load += new System.EventHandler(this.frmUtasLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUtasNeve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUtvonal;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kód;
        private System.Windows.Forms.DataGridViewTextBoxColumn Név;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cím;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÚtKód;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kezdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uticél;
    }
}