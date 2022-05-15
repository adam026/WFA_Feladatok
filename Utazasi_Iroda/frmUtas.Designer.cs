namespace Utazasi_Iroda
{
    partial class frmUtas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUtasKod = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.cbJelentkezes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbKereses = new System.Windows.Forms.PictureBox();
            this.pbMentes = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbTorles = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbUres = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKereses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utas kód:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jelentkezés:";
            // 
            // tbUtasKod
            // 
            this.tbUtasKod.Enabled = false;
            this.tbUtasKod.Location = new System.Drawing.Point(133, 18);
            this.tbUtasKod.Name = "tbUtasKod";
            this.tbUtasKod.Size = new System.Drawing.Size(100, 26);
            this.tbUtasKod.TabIndex = 1;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(133, 67);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(228, 26);
            this.tbNev.TabIndex = 1;
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(133, 122);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(228, 197);
            this.rtbCim.TabIndex = 2;
            this.rtbCim.Text = "";
            // 
            // cbJelentkezes
            // 
            this.cbJelentkezes.FormattingEnabled = true;
            this.cbJelentkezes.Location = new System.Drawing.Point(116, 362);
            this.cbJelentkezes.Name = "cbJelentkezes";
            this.cbJelentkezes.Size = new System.Drawing.Size(100, 28);
            this.cbJelentkezes.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Keresés";
            // 
            // pbKereses
            // 
            this.pbKereses.InitialImage = global::Utazasi_Iroda.Properties.Resources.keres;
            this.pbKereses.Location = new System.Drawing.Point(407, 24);
            this.pbKereses.Name = "pbKereses";
            this.pbKereses.Size = new System.Drawing.Size(63, 58);
            this.pbKereses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKereses.TabIndex = 4;
            this.pbKereses.TabStop = false;
            this.pbKereses.Click += new System.EventHandler(this.pbKereses_Click);
            // 
            // pbMentes
            // 
            this.pbMentes.InitialImage = global::Utazasi_Iroda.Properties.Resources.ment;
            this.pbMentes.Location = new System.Drawing.Point(407, 131);
            this.pbMentes.Name = "pbMentes";
            this.pbMentes.Size = new System.Drawing.Size(63, 58);
            this.pbMentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMentes.TabIndex = 4;
            this.pbMentes.TabStop = false;
            this.pbMentes.Click += new System.EventHandler(this.pbMentes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mentés";
            // 
            // pbTorles
            // 
            this.pbTorles.Enabled = false;
            this.pbTorles.InitialImage = global::Utazasi_Iroda.Properties.Resources.delete;
            this.pbTorles.Location = new System.Drawing.Point(407, 226);
            this.pbTorles.Name = "pbTorles";
            this.pbTorles.Size = new System.Drawing.Size(63, 58);
            this.pbTorles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTorles.TabIndex = 4;
            this.pbTorles.TabStop = false;
            this.pbTorles.Click += new System.EventHandler(this.pbTorles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Törlés";
            // 
            // pbUres
            // 
            this.pbUres.InitialImage = global::Utazasi_Iroda.Properties.Resources.ures;
            this.pbUres.Location = new System.Drawing.Point(407, 332);
            this.pbUres.Name = "pbUres";
            this.pbUres.Size = new System.Drawing.Size(63, 58);
            this.pbUres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUres.TabIndex = 4;
            this.pbUres.TabStop = false;
            this.pbUres.Click += new System.EventHandler(this.pbUres_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Üres űrlap";
            // 
            // frmUtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 454);
            this.Controls.Add(this.pbUres);
            this.Controls.Add(this.pbTorles);
            this.Controls.Add(this.pbMentes);
            this.Controls.Add(this.pbKereses);
            this.Controls.Add(this.cbJelentkezes);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbUtasKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUtas";
            this.Text = "Utas";
            this.Load += new System.EventHandler(this.frmUtas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKereses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUtasKod;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.RichTextBox rtbCim;
        private System.Windows.Forms.ComboBox cbJelentkezes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbKereses;
        private System.Windows.Forms.PictureBox pbMentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbTorles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbUres;
        private System.Windows.Forms.Label label8;
    }
}