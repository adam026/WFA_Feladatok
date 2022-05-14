namespace TojasGyar
{
    partial class FrmMain
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
            this.btnTermeles = new System.Windows.Forms.Button();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.btnStatisztika = new System.Windows.Forms.Button();
            this.btnKimutatas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTermeles
            // 
            this.btnTermeles.Location = new System.Drawing.Point(13, 14);
            this.btnTermeles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTermeles.Name = "btnTermeles";
            this.btnTermeles.Size = new System.Drawing.Size(445, 93);
            this.btnTermeles.TabIndex = 0;
            this.btnTermeles.Text = "Termelés";
            this.btnTermeles.UseVisualStyleBackColor = true;
            this.btnTermeles.Click += new System.EventHandler(this.btnTermeles_Click);
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(466, 14);
            this.pbKep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(384, 402);
            this.pbKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKep.TabIndex = 1;
            this.pbKep.TabStop = false;
            // 
            // btnStatisztika
            // 
            this.btnStatisztika.Location = new System.Drawing.Point(13, 117);
            this.btnStatisztika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatisztika.Name = "btnStatisztika";
            this.btnStatisztika.Size = new System.Drawing.Size(445, 93);
            this.btnStatisztika.TabIndex = 0;
            this.btnStatisztika.Text = "Statisztika";
            this.btnStatisztika.UseVisualStyleBackColor = true;
            this.btnStatisztika.Click += new System.EventHandler(this.btnStatisztika_Click);
            // 
            // btnKimutatas
            // 
            this.btnKimutatas.Location = new System.Drawing.Point(13, 220);
            this.btnKimutatas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKimutatas.Name = "btnKimutatas";
            this.btnKimutatas.Size = new System.Drawing.Size(445, 93);
            this.btnKimutatas.TabIndex = 0;
            this.btnKimutatas.Text = "Kimutatás";
            this.btnKimutatas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(13, 323);
            this.btnKilepes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(445, 93);
            this.btnKilepes.TabIndex = 0;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 427);
            this.ControlBox = false;
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKimutatas);
            this.Controls.Add(this.btnStatisztika);
            this.Controls.Add(this.btnTermeles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTermeles;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.Button btnStatisztika;
        private System.Windows.Forms.Button btnKimutatas;
        private System.Windows.Forms.Button btnKilepes;
    }
}

