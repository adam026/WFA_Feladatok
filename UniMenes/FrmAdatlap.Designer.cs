namespace UniMenes
{
    partial class FrmAdatlap
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
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.cbFajta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTulajdonos = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajta:";
            // 
            // nudSuly
            // 
            this.nudSuly.Location = new System.Drawing.Point(214, 166);
            this.nudSuly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSuly.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(95, 26);
            this.nudSuly.TabIndex = 1;
            this.nudSuly.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(439, 30);
            this.pbKep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(228, 275);
            this.pbKep.TabIndex = 2;
            this.pbKep.TabStop = false;
            // 
            // cbFajta
            // 
            this.cbFajta.FormattingEnabled = true;
            this.cbFajta.Location = new System.Drawing.Point(176, 57);
            this.cbFajta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFajta.Name = "cbFajta";
            this.cbFajta.Size = new System.Drawing.Size(180, 28);
            this.cbFajta.TabIndex = 3;
            this.cbFajta.SelectedIndexChanged += new System.EventHandler(this.cbFajta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tulajdonos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nem:";
            // 
            // cbTulajdonos
            // 
            this.cbTulajdonos.FormattingEnabled = true;
            this.cbTulajdonos.Location = new System.Drawing.Point(176, 111);
            this.cbTulajdonos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTulajdonos.Name = "cbTulajdonos";
            this.cbTulajdonos.Size = new System.Drawing.Size(180, 28);
            this.cbTulajdonos.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(625, 66);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Új egyed rögzítése az adatbázisba!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.Checked = true;
            this.rbKanca.Location = new System.Drawing.Point(176, 227);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(70, 24);
            this.rbKanca.TabIndex = 5;
            this.rbKanca.TabStop = true;
            this.rbKanca.Text = "kanca";
            this.rbKanca.UseVisualStyleBackColor = true;
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.Location = new System.Drawing.Point(281, 227);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(75, 24);
            this.rbCsodor.TabIndex = 5;
            this.rbCsodor.Text = "csődör";
            this.rbCsodor.UseVisualStyleBackColor = true;
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 465);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTulajdonos);
            this.Controls.Add(this.cbFajta);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdatlap";
            this.Text = "FrmAdatlap";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSuly;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.ComboBox cbFajta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTulajdonos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbKanca;
        private System.Windows.Forms.RadioButton rbCsodor;
    }
}