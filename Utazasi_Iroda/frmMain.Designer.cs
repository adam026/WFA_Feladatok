namespace Utazasi_Iroda
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idegenvezetőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szállásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.útvonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.túraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.lblDatum = new System.Windows.Forms.Label();
            this.T_KOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kezdete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vége = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idegenvezeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szállás = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utasToolStripMenuItem,
            this.idegenvezetőToolStripMenuItem,
            this.szállásToolStripMenuItem,
            this.útvonalToolStripMenuItem,
            this.túraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 87);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utasToolStripMenuItem
            // 
            this.utasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.utasToolStripMenuItem.Image = global::Utazasi_Iroda.Properties.Resources.utas1;
            this.utasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utasToolStripMenuItem.Name = "utasToolStripMenuItem";
            this.utasToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.utasToolStripMenuItem.Text = "Utas";
            this.utasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.szerkesztésToolStripMenuItem_Click);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // idegenvezetőToolStripMenuItem
            // 
            this.idegenvezetőToolStripMenuItem.Image = global::Utazasi_Iroda.Properties.Resources.idegenvezeto;
            this.idegenvezetőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.idegenvezetőToolStripMenuItem.Name = "idegenvezetőToolStripMenuItem";
            this.idegenvezetőToolStripMenuItem.Size = new System.Drawing.Size(89, 83);
            this.idegenvezetőToolStripMenuItem.Text = "Idegenvezető";
            this.idegenvezetőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // szállásToolStripMenuItem
            // 
            this.szállásToolStripMenuItem.Image = global::Utazasi_Iroda.Properties.Resources.szallas;
            this.szállásToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szállásToolStripMenuItem.Name = "szállásToolStripMenuItem";
            this.szállásToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.szállásToolStripMenuItem.Text = "Szállás";
            this.szállásToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // útvonalToolStripMenuItem
            // 
            this.útvonalToolStripMenuItem.Image = global::Utazasi_Iroda.Properties.Resources.utvonal;
            this.útvonalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.útvonalToolStripMenuItem.Name = "útvonalToolStripMenuItem";
            this.útvonalToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.útvonalToolStripMenuItem.Text = "Útvonal";
            this.útvonalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // túraToolStripMenuItem
            // 
            this.túraToolStripMenuItem.Image = global::Utazasi_Iroda.Properties.Resources.tura;
            this.túraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.túraToolStripMenuItem.Name = "túraToolStripMenuItem";
            this.túraToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.túraToolStripMenuItem.Text = "Túra";
            this.túraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Túrák:";
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_KOD,
            this.Cel,
            this.Kezdete,
            this.Vége,
            this.Idegenvezeto,
            this.Szállás,
            this.Ár});
            this.dgvMain.Location = new System.Drawing.Point(16, 168);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(761, 218);
            this.dgvMain.TabIndex = 2;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(16, 393);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(202, 20);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "###AKTUALIS DATUM###";
            // 
            // T_KOD
            // 
            this.T_KOD.HeaderText = "Túra kód";
            this.T_KOD.Name = "T_KOD";
            // 
            // Cel
            // 
            this.Cel.HeaderText = "Cél";
            this.Cel.Name = "Cel";
            // 
            // Kezdete
            // 
            this.Kezdete.HeaderText = "Kezdet";
            this.Kezdete.Name = "Kezdete";
            // 
            // Vége
            // 
            this.Vége.HeaderText = "Vége";
            this.Vége.Name = "Vége";
            // 
            // Idegenvezeto
            // 
            this.Idegenvezeto.HeaderText = "Idegenvezető";
            this.Idegenvezeto.Name = "Idegenvezeto";
            // 
            // Szállás
            // 
            this.Szállás.HeaderText = "Szállás";
            this.Szállás.Name = "Szállás";
            // 
            // Ár
            // 
            this.Ár.HeaderText = "Ár (Ft)";
            this.Ár.Name = "Ár";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 441);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Napos Oldal Utazási Iroda";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idegenvezetőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szállásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem útvonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem túraToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_KOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kezdete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vége;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idegenvezeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szállás;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ár;
    }
}

