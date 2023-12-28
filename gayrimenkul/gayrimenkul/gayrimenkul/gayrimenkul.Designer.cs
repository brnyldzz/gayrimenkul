namespace gayrimenkul
{
    partial class gayrimenkul
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.siteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saticiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aliciMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.siteBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliciBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saticiBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteMenu,
            this.aliciMenu,
            this.saticiMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(886, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // siteMenu
            // 
            this.siteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteBilgileriToolStripMenuItem});
            this.siteMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.siteMenu.Name = "siteMenu";
            this.siteMenu.Size = new System.Drawing.Size(47, 24);
            this.siteMenu.Text = "Site";
            // 
            // saticiMenu
            // 
            this.saticiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saticiBilgileriToolStripMenuItem});
            this.saticiMenu.Name = "saticiMenu";
            this.saticiMenu.Size = new System.Drawing.Size(58, 24);
            this.saticiMenu.Text = "Satıcı";
            // 
            // aliciMenu
            // 
            this.aliciMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliciBilgileriToolStripMenuItem});
            this.aliciMenu.Name = "aliciMenu";
            this.aliciMenu.Size = new System.Drawing.Size(51, 24);
            this.aliciMenu.Text = "Alıcı";
            // 
            // siteBilgileriToolStripMenuItem
            // 
            this.siteBilgileriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siteBilgileriToolStripMenuItem.Name = "siteBilgileriToolStripMenuItem";
            this.siteBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.siteBilgileriToolStripMenuItem.Text = "Site Bilgileri";
            this.siteBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siteBilgileriToolStripMenuItem_Click);
            // 
            // aliciBilgileriToolStripMenuItem
            // 
            this.aliciBilgileriToolStripMenuItem.Name = "aliciBilgileriToolStripMenuItem";
            this.aliciBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.aliciBilgileriToolStripMenuItem.Text = "Alıcı Bilgileri";
            this.aliciBilgileriToolStripMenuItem.Click += new System.EventHandler(this.aliciBilgileriToolStripMenuItem_Click);
            // 
            // saticiBilgileriToolStripMenuItem
            // 
            this.saticiBilgileriToolStripMenuItem.Name = "saticiBilgileriToolStripMenuItem";
            this.saticiBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saticiBilgileriToolStripMenuItem.Text = "Satıcı Bilgileri";
            this.saticiBilgileriToolStripMenuItem.Click += new System.EventHandler(this.saticiBilgileriToolStripMenuItem_Click);
            // 
            // gayrimenkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "gayrimenkul";
            this.Text = "gayrimenkul";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem siteMenu;
        private System.Windows.Forms.ToolStripMenuItem saticiMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem aliciMenu;
        private System.Windows.Forms.ToolStripMenuItem siteBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aliciBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saticiBilgileriToolStripMenuItem;
    }
}



