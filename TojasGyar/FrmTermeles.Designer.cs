namespace TojasGyar
{
    partial class FrmTermeles
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbTojas = new System.Windows.Forms.ComboBox();
            this.cbMunkas = new System.Windows.Forms.ComboBox();
            this.nudMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tojas_Szine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Tojas_Szine,
            this.Mennyiseg,
            this.Munkas});
            this.dgvMain.Location = new System.Drawing.Point(20, 20);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(745, 296);
            this.dgvMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.nudMennyiseg);
            this.groupBox1.Controls.Add(this.cbMunkas);
            this.groupBox1.Controls.Add(this.cbTojas);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új bejegyzés:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tojás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Munkás:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(11, 108);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(173, 26);
            this.dtpDatum.TabIndex = 1;
            this.dtpDatum.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // cbTojas
            // 
            this.cbTojas.FormattingEnabled = true;
            this.cbTojas.Location = new System.Drawing.Point(199, 108);
            this.cbTojas.Name = "cbTojas";
            this.cbTojas.Size = new System.Drawing.Size(123, 28);
            this.cbTojas.TabIndex = 2;
            // 
            // cbMunkas
            // 
            this.cbMunkas.FormattingEnabled = true;
            this.cbMunkas.Location = new System.Drawing.Point(507, 108);
            this.cbMunkas.Name = "cbMunkas";
            this.cbMunkas.Size = new System.Drawing.Size(232, 28);
            this.cbMunkas.TabIndex = 2;
            // 
            // nudMennyiseg
            // 
            this.nudMennyiseg.Location = new System.Drawing.Point(346, 108);
            this.nudMennyiseg.Name = "nudMennyiseg";
            this.nudMennyiseg.Size = new System.Drawing.Size(120, 26);
            this.nudMennyiseg.TabIndex = 3;
            this.nudMennyiseg.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(11, 153);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(728, 54);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Új bejegyzés felvétele!";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Tojas_Szine
            // 
            this.Tojas_Szine.HeaderText = "Tojás Színe";
            this.Tojas_Szine.Name = "Tojas_Szine";
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.FillWeight = 50F;
            this.Mennyiseg.HeaderText = "Mennyiség";
            this.Mennyiseg.Name = "Mennyiseg";
            // 
            // Munkas
            // 
            this.Munkas.FillWeight = 150F;
            this.Munkas.HeaderText = "Munkás";
            this.Munkas.Name = "Munkas";
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTermeles";
            this.Text = "Termelés";
            this.Load += new System.EventHandler(this.FrmTermeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.NumericUpDown nudMennyiseg;
        private System.Windows.Forms.ComboBox cbMunkas;
        private System.Windows.Forms.ComboBox cbTojas;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tojas_Szine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkas;
    }
}