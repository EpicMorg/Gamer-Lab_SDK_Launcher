namespace glSDK.UI.LauncherForms
{
    partial class FrmContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContent));
            this.metroTilePakExplorer = new MetroFramework.Controls.MetroTile();
            this.metroTilePakScape = new MetroFramework.Controls.MetroTile();
            this.metroTileBsp2Zip = new MetroFramework.Controls.MetroTile();
            this.metroTileGamefgManager = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTilePakExplorer
            // 
            this.metroTilePakExplorer.ActiveControl = null;
            this.metroTilePakExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilePakExplorer.Location = new System.Drawing.Point(23, 63);
            this.metroTilePakExplorer.Name = "metroTilePakExplorer";
            this.metroTilePakExplorer.Size = new System.Drawing.Size(90, 90);
            this.metroTilePakExplorer.TabIndex = 25;
            this.metroTilePakExplorer.Text = "PakExplorer";
            this.metroTilePakExplorer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilePakExplorer.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTilePakExplorer.TileImage")));
            this.metroTilePakExplorer.UseSelectable = true;
            // 
            // metroTilePakScape
            // 
            this.metroTilePakScape.ActiveControl = null;
            this.metroTilePakScape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilePakScape.Location = new System.Drawing.Point(119, 63);
            this.metroTilePakScape.Name = "metroTilePakScape";
            this.metroTilePakScape.Size = new System.Drawing.Size(90, 90);
            this.metroTilePakScape.TabIndex = 25;
            this.metroTilePakScape.Text = "PakScape";
            this.metroTilePakScape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilePakScape.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTilePakScape.TileImage")));
            this.metroTilePakScape.UseSelectable = true;
            // 
            // metroTileBsp2Zip
            // 
            this.metroTileBsp2Zip.ActiveControl = null;
            this.metroTileBsp2Zip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileBsp2Zip.Location = new System.Drawing.Point(215, 63);
            this.metroTileBsp2Zip.Name = "metroTileBsp2Zip";
            this.metroTileBsp2Zip.Size = new System.Drawing.Size(90, 90);
            this.metroTileBsp2Zip.TabIndex = 25;
            this.metroTileBsp2Zip.Text = "Bsp2Zip";
            this.metroTileBsp2Zip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileBsp2Zip.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileBsp2Zip.TileImage")));
            this.metroTileBsp2Zip.UseSelectable = true;
            // 
            // metroTileGamefgManager
            // 
            this.metroTileGamefgManager.ActiveControl = null;
            this.metroTileGamefgManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileGamefgManager.Location = new System.Drawing.Point(311, 63);
            this.metroTileGamefgManager.Name = "metroTileGamefgManager";
            this.metroTileGamefgManager.Size = new System.Drawing.Size(90, 90);
            this.metroTileGamefgManager.TabIndex = 25;
            this.metroTileGamefgManager.Text = "Game Cfg Manager";
            this.metroTileGamefgManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileGamefgManager.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileGamefgManager.TileImage")));
            this.metroTileGamefgManager.UseSelectable = true;
            // 
            // FrmContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 377);
            this.Controls.Add(this.metroTileGamefgManager);
            this.Controls.Add(this.metroTileBsp2Zip);
            this.Controls.Add(this.metroTilePakScape);
            this.Controls.Add(this.metroTilePakExplorer);
            this.MaximizeBox = false;
            this.Name = "FrmContent";
            this.Resizable = false;
            this.Text = "Content";
            this.Load += new System.EventHandler(this.FrmContent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTilePakExplorer;
        private MetroFramework.Controls.MetroTile metroTilePakScape;
        private MetroFramework.Controls.MetroTile metroTileBsp2Zip;
        private MetroFramework.Controls.MetroTile metroTileGamefgManager;
    }
}