namespace Zoldseges
{
    partial class FrmUjTermek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbEgysegar = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEgysegar);
            this.groupBox1.Controls.Add(this.tbNev);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új termék adatai:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Egységár:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(135, 35);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(68, 26);
            this.tbId.TabIndex = 1;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(135, 85);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(147, 26);
            this.tbNev.TabIndex = 1;
            // 
            // tbEgysegar
            // 
            this.tbEgysegar.Location = new System.Drawing.Point(135, 142);
            this.tbEgysegar.Name = "tbEgysegar";
            this.tbEgysegar.Size = new System.Drawing.Size(147, 26);
            this.tbEgysegar.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 261);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(311, 54);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Új termék rögzítése";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FrmUjTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 327);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUjTermek";
            this.Text = "Új termék rögzítése";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEgysegar;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
    }
}