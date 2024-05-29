namespace PuncakLur
{
    partial class Utama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMBONGANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pENDAKIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGBAWAANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.bOOKINGToolStripMenuItem,
            this.rOMBONGANToolStripMenuItem,
            this.pENDAKIToolStripMenuItem,
            this.bARANGToolStripMenuItem,
            this.bARANGBAWAANToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // bOOKINGToolStripMenuItem
            // 
            this.bOOKINGToolStripMenuItem.Name = "bOOKINGToolStripMenuItem";
            this.bOOKINGToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bOOKINGToolStripMenuItem.Text = "BOOKING";
            this.bOOKINGToolStripMenuItem.Click += new System.EventHandler(this.bOOKINGToolStripMenuItem_Click);
            // 
            // rOMBONGANToolStripMenuItem
            // 
            this.rOMBONGANToolStripMenuItem.Name = "rOMBONGANToolStripMenuItem";
            this.rOMBONGANToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.rOMBONGANToolStripMenuItem.Text = "ROMBONGAN";
            this.rOMBONGANToolStripMenuItem.Click += new System.EventHandler(this.rOMBONGANToolStripMenuItem_Click);
            // 
            // pENDAKIToolStripMenuItem
            // 
            this.pENDAKIToolStripMenuItem.Name = "pENDAKIToolStripMenuItem";
            this.pENDAKIToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pENDAKIToolStripMenuItem.Text = "PENDAKI";
            this.pENDAKIToolStripMenuItem.Click += new System.EventHandler(this.pENDAKIToolStripMenuItem_Click);
            // 
            // bARANGToolStripMenuItem
            // 
            this.bARANGToolStripMenuItem.Name = "bARANGToolStripMenuItem";
            this.bARANGToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.bARANGToolStripMenuItem.Text = "BARANG";
            this.bARANGToolStripMenuItem.Click += new System.EventHandler(this.bARANGToolStripMenuItem_Click);
            // 
            // bARANGBAWAANToolStripMenuItem
            // 
            this.bARANGBAWAANToolStripMenuItem.Name = "bARANGBAWAANToolStripMenuItem";
            this.bARANGBAWAANToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.bARANGBAWAANToolStripMenuItem.Text = "BARANG BAWAAN";
            this.bARANGBAWAANToolStripMenuItem.Click += new System.EventHandler(this.bARANGBAWAANToolStripMenuItem_Click);
            // 
            // Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMBONGANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pENDAKIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARANGBAWAANToolStripMenuItem;
    }
}