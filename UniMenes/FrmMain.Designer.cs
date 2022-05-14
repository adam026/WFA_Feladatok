namespace UniMenes
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Város = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Súly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tenyésztőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.párkeresőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBejelentesek = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fajta,
            this.Tulajdonos,
            this.Város,
            this.Súly,
            this.Nem});
            this.dgvMain.Location = new System.Drawing.Point(12, 87);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(776, 351);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
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
            // Város
            // 
            this.Város.HeaderText = "Város";
            this.Város.Name = "Város";
            // 
            // Súly
            // 
            this.Súly.HeaderText = "Súly";
            this.Súly.Name = "Súly";
            // 
            // Nem
            // 
            this.Nem.HeaderText = "Nem";
            this.Nem.Name = "Nem";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenyésztőkToolStripMenuItem,
            this.párkeresőToolStripMenuItem,
            this.tsmBejelentesek});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 73);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tenyésztőkToolStripMenuItem
            // 
            this.tenyésztőkToolStripMenuItem.Image = global::UniMenes.Properties.Resources.wizard;
            this.tenyésztőkToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tenyésztőkToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tenyésztőkToolStripMenuItem.Name = "tenyésztőkToolStripMenuItem";
            this.tenyésztőkToolStripMenuItem.Size = new System.Drawing.Size(76, 69);
            this.tenyésztőkToolStripMenuItem.Text = "Tenyésztők";
            this.tenyésztőkToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // párkeresőToolStripMenuItem
            // 
            this.párkeresőToolStripMenuItem.Image = global::UniMenes.Properties.Resources.love;
            this.párkeresőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.párkeresőToolStripMenuItem.Name = "párkeresőToolStripMenuItem";
            this.párkeresőToolStripMenuItem.Size = new System.Drawing.Size(70, 69);
            this.párkeresőToolStripMenuItem.Text = "Párkereső";
            this.párkeresőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmBejelentesek
            // 
            this.tsmBejelentesek.Image = global::UniMenes.Properties.Resources.unicorn;
            this.tsmBejelentesek.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmBejelentesek.Name = "tsmBejelentesek";
            this.tsmBejelentesek.Size = new System.Drawing.Size(72, 69);
            this.tsmBejelentesek.Text = "Bejelentés";
            this.tsmBejelentesek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmBejelentesek.Click += new System.EventHandler(this.tsmBejelentesek_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Unikornis Ménes Manager 2021";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tulajdonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Város;
        private System.Windows.Forms.DataGridViewTextBoxColumn Súly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tenyésztőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem párkeresőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBejelentesek;
    }
}

