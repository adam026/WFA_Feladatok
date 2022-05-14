namespace TojasGyar
{
    partial class frmStatisztika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMunkas = new System.Windows.Forms.ComboBox();
            this.nudHonap = new System.Windows.Forms.NumericUpDown();
            this.dgvStatisztika = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxTojas = new System.Windows.Forms.TextBox();
            this.tbMaxSuly = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisztika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkás neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kiválasztott hónap sorszáma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termelési napló:";
            // 
            // cbMunkas
            // 
            this.cbMunkas.FormattingEnabled = true;
            this.cbMunkas.Location = new System.Drawing.Point(148, 10);
            this.cbMunkas.Name = "cbMunkas";
            this.cbMunkas.Size = new System.Drawing.Size(199, 28);
            this.cbMunkas.TabIndex = 1;
            this.cbMunkas.SelectedIndexChanged += new System.EventHandler(this.cbMunkas_SelectedIndexChanged);
            // 
            // nudHonap
            // 
            this.nudHonap.Location = new System.Drawing.Point(614, 12);
            this.nudHonap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHonap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHonap.Name = "nudHonap";
            this.nudHonap.Size = new System.Drawing.Size(39, 26);
            this.nudHonap.TabIndex = 2;
            this.nudHonap.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHonap.ValueChanged += new System.EventHandler(this.nudHonap_ValueChanged);
            // 
            // dgvStatisztika
            // 
            this.dgvStatisztika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatisztika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisztika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Munkas,
            this.Mennyiseg});
            this.dgvStatisztika.Location = new System.Drawing.Point(16, 103);
            this.dgvStatisztika.Name = "dgvStatisztika";
            this.dgvStatisztika.RowHeadersVisible = false;
            this.dgvStatisztika.Size = new System.Drawing.Size(637, 287);
            this.dgvStatisztika.TabIndex = 3;
            // 
            // Datum
            // 
            this.Datum.FillWeight = 120F;
            this.Datum.HeaderText = "Dátum";
            this.Datum.Name = "Datum";
            // 
            // Munkas
            // 
            this.Munkas.FillWeight = 120F;
            this.Munkas.HeaderText = "Munkás";
            this.Munkas.Name = "Munkas";
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.FillWeight = 60F;
            this.Mennyiseg.HeaderText = "Mennyiség";
            this.Mennyiseg.Name = "Mennyiseg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "A hónapban legtöbbet gyártott tojás színe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "A hónapban termelt tojások összsúlya:";
            // 
            // tbMaxTojas
            // 
            this.tbMaxTojas.Location = new System.Drawing.Point(529, 401);
            this.tbMaxTojas.Name = "tbMaxTojas";
            this.tbMaxTojas.Size = new System.Drawing.Size(124, 26);
            this.tbMaxTojas.TabIndex = 4;
            // 
            // tbMaxSuly
            // 
            this.tbMaxSuly.Location = new System.Drawing.Point(529, 431);
            this.tbMaxSuly.Name = "tbMaxSuly";
            this.tbMaxSuly.Size = new System.Drawing.Size(124, 26);
            this.tbMaxSuly.TabIndex = 4;
            // 
            // frmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 477);
            this.Controls.Add(this.tbMaxSuly);
            this.Controls.Add(this.tbMaxTojas);
            this.Controls.Add(this.dgvStatisztika);
            this.Controls.Add(this.nudHonap);
            this.Controls.Add(this.cbMunkas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStatisztika";
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.frmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisztika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMunkas;
        private System.Windows.Forms.NumericUpDown nudHonap;
        private System.Windows.Forms.DataGridView dgvStatisztika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyiseg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxTojas;
        private System.Windows.Forms.TextBox tbMaxSuly;
    }
}