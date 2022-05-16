namespace Zoldseges
{
    partial class FrmUjEladas
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
            this.cbTermekek = new System.Windows.Forms.ComboBox();
            this.tbTermekAr = new System.Windows.Forms.TextBox();
            this.nudMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFizetendo = new System.Windows.Forms.TextBox();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnUjVasarlas = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "A kiválasztott termék ára / kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eladott mennyiség (kg):";
            // 
            // cbTermekek
            // 
            this.cbTermekek.FormattingEnabled = true;
            this.cbTermekek.Location = new System.Drawing.Point(326, 32);
            this.cbTermekek.Name = "cbTermekek";
            this.cbTermekek.Size = new System.Drawing.Size(212, 28);
            this.cbTermekek.TabIndex = 1;
            this.cbTermekek.SelectedIndexChanged += new System.EventHandler(this.cbTermekek_SelectedIndexChanged);
            // 
            // tbTermekAr
            // 
            this.tbTermekAr.Enabled = false;
            this.tbTermekAr.Location = new System.Drawing.Point(326, 84);
            this.tbTermekAr.Name = "tbTermekAr";
            this.tbTermekAr.Size = new System.Drawing.Size(168, 26);
            this.tbTermekAr.TabIndex = 2;
            // 
            // nudMennyiseg
            // 
            this.nudMennyiseg.Location = new System.Drawing.Point(326, 141);
            this.nudMennyiseg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMennyiseg.Name = "nudMennyiseg";
            this.nudMennyiseg.Size = new System.Drawing.Size(76, 26);
            this.nudMennyiseg.TabIndex = 3;
            this.nudMennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMennyiseg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMennyiseg.ValueChanged += new System.EventHandler(this.nudMennyiseg_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fizetendő:";
            // 
            // tbFizetendo
            // 
            this.tbFizetendo.Location = new System.Drawing.Point(326, 278);
            this.tbFizetendo.Name = "tbFizetendo";
            this.tbFizetendo.Size = new System.Drawing.Size(168, 26);
            this.tbFizetendo.TabIndex = 2;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(49, 399);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(212, 58);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "Bezárás";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnUjVasarlas
            // 
            this.btnUjVasarlas.Location = new System.Drawing.Point(326, 399);
            this.btnUjVasarlas.Name = "btnUjVasarlas";
            this.btnUjVasarlas.Size = new System.Drawing.Size(212, 58);
            this.btnUjVasarlas.TabIndex = 4;
            this.btnUjVasarlas.Text = "Új vásárlás";
            this.btnUjVasarlas.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(49, 326);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(489, 58);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Eladás rögzítése";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmUjEladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 478);
            this.Controls.Add(this.btnUjVasarlas);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.nudMennyiseg);
            this.Controls.Add(this.tbFizetendo);
            this.Controls.Add(this.tbTermekAr);
            this.Controls.Add(this.cbTermekek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUjEladas";
            this.Text = "FrmUjEladas";
            this.Load += new System.EventHandler(this.FrmUjEladas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTermekek;
        private System.Windows.Forms.TextBox tbTermekAr;
        private System.Windows.Forms.NumericUpDown nudMennyiseg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFizetendo;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnUjVasarlas;
        private System.Windows.Forms.Button btnInsert;
    }
}