namespace Zoldseges
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTermek = new System.Windows.Forms.TextBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Dátum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termék = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bevétel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUjTermek = new System.Windows.Forms.Button();
            this.btnUjEladas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szűrés termék alapján:";
            // 
            // tbTermek
            // 
            this.tbTermek.Location = new System.Drawing.Point(366, 29);
            this.tbTermek.Name = "tbTermek";
            this.tbTermek.Size = new System.Drawing.Size(269, 26);
            this.tbTermek.TabIndex = 1;
            this.tbTermek.TextChanged += new System.EventHandler(this.tbTermek_TextChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dátum,
            this.Termék,
            this.Bevétel});
            this.dgvMain.Location = new System.Drawing.Point(12, 83);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(786, 270);
            this.dgvMain.TabIndex = 2;
            // 
            // Dátum
            // 
            this.Dátum.HeaderText = "Dátum";
            this.Dátum.Name = "Dátum";
            // 
            // Termék
            // 
            this.Termék.HeaderText = "Termék";
            this.Termék.Name = "Termék";
            // 
            // Bevétel
            // 
            this.Bevétel.HeaderText = "Bevétel";
            this.Bevétel.Name = "Bevétel";
            // 
            // btnUjTermek
            // 
            this.btnUjTermek.Location = new System.Drawing.Point(13, 373);
            this.btnUjTermek.Name = "btnUjTermek";
            this.btnUjTermek.Size = new System.Drawing.Size(371, 59);
            this.btnUjTermek.TabIndex = 3;
            this.btnUjTermek.Text = "Új terméktípus rögzítése";
            this.btnUjTermek.UseVisualStyleBackColor = true;
            this.btnUjTermek.Click += new System.EventHandler(this.btnUjTermek_Click);
            // 
            // btnUjEladas
            // 
            this.btnUjEladas.Location = new System.Drawing.Point(427, 373);
            this.btnUjEladas.Name = "btnUjEladas";
            this.btnUjEladas.Size = new System.Drawing.Size(371, 59);
            this.btnUjEladas.TabIndex = 3;
            this.btnUjEladas.Text = "Új eladás rögzítése";
            this.btnUjEladas.UseVisualStyleBackColor = true;
            this.btnUjEladas.Click += new System.EventHandler(this.btnUjEladas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 444);
            this.Controls.Add(this.btnUjEladas);
            this.Controls.Add(this.btnUjTermek);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.tbTermek);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Zöldség/Gyümölcs";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTermek;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dátum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termék;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bevétel;
        private System.Windows.Forms.Button btnUjTermek;
        private System.Windows.Forms.Button btnUjEladas;
    }
}

