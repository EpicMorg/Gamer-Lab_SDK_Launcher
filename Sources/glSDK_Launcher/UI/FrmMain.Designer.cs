namespace glSDK.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.metroTileAbout = new MetroFramework.Controls.MetroTile();
            this.metroTileManuals = new MetroFramework.Controls.MetroTile();
            this.metroTileContent = new MetroFramework.Controls.MetroTile();
            this.metroTileLinks = new MetroFramework.Controls.MetroTile();
            this.metroTileModding = new MetroFramework.Controls.MetroTile();
            this.metroTileCompiling = new MetroFramework.Controls.MetroTile();
            this.metroTileTexturing = new MetroFramework.Controls.MetroTile();
            this.metroTileMapping = new MetroFramework.Controls.MetroTile();
            this.metroTileSettings = new MetroFramework.Controls.MetroTile();
            this.metroTileModelling = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTileGit = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTileOther = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileAbout
            // 
            this.metroTileAbout.ActiveControl = null;
            this.metroTileAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileAbout, "metroTileAbout");
            this.metroTileAbout.Name = "metroTileAbout";
            this.metroTileAbout.UseSelectable = true;
            this.metroTileAbout.Click += new System.EventHandler(this.metroTileAbout_Click);
            // 
            // metroTileManuals
            // 
            this.metroTileManuals.ActiveControl = null;
            this.metroTileManuals.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileManuals, "metroTileManuals");
            this.metroTileManuals.Name = "metroTileManuals";
            this.metroTileManuals.Tag = "";
            this.metroTileManuals.UseSelectable = true;
            this.metroTileManuals.Click += new System.EventHandler(this.metroTileManuals_Click);
            // 
            // metroTileContent
            // 
            this.metroTileContent.ActiveControl = null;
            this.metroTileContent.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileContent, "metroTileContent");
            this.metroTileContent.Name = "metroTileContent";
            this.metroTileContent.UseSelectable = true;
            this.metroTileContent.Click += new System.EventHandler(this.metroTileContent_Click);
            // 
            // metroTileLinks
            // 
            this.metroTileLinks.ActiveControl = null;
            this.metroTileLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileLinks, "metroTileLinks");
            this.metroTileLinks.Name = "metroTileLinks";
            this.metroTileLinks.TileImage = global::glSDK.Properties.Resources.internet_dark;
            this.metroTileLinks.UseSelectable = true;
            this.metroTileLinks.Click += new System.EventHandler(this.metroTileFemLinks_Click);
            // 
            // metroTileModding
            // 
            this.metroTileModding.ActiveControl = null;
            this.metroTileModding.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileModding, "metroTileModding");
            this.metroTileModding.Name = "metroTileModding";
            this.metroTileModding.UseSelectable = true;
            this.metroTileModding.Click += new System.EventHandler(this.metroTileModing_Click);
            // 
            // metroTileCompiling
            // 
            this.metroTileCompiling.ActiveControl = null;
            this.metroTileCompiling.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileCompiling, "metroTileCompiling");
            this.metroTileCompiling.Name = "metroTileCompiling";
            this.metroTileCompiling.UseSelectable = true;
            this.metroTileCompiling.Click += new System.EventHandler(this.metroTileCompiling_Click);
            // 
            // metroTileTexturing
            // 
            this.metroTileTexturing.ActiveControl = null;
            this.metroTileTexturing.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileTexturing, "metroTileTexturing");
            this.metroTileTexturing.Name = "metroTileTexturing";
            this.metroTileTexturing.UseSelectable = true;
            this.metroTileTexturing.Click += new System.EventHandler(this.metroTileTexturing_Click);
            // 
            // metroTileMapping
            // 
            this.metroTileMapping.ActiveControl = null;
            this.metroTileMapping.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileMapping, "metroTileMapping");
            this.metroTileMapping.Name = "metroTileMapping";
            this.metroTileMapping.UseSelectable = true;
            this.metroTileMapping.Click += new System.EventHandler(this.metroTileMapping_Click);
            // 
            // metroTileSettings
            // 
            this.metroTileSettings.ActiveControl = null;
            this.metroTileSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileSettings, "metroTileSettings");
            this.metroTileSettings.Name = "metroTileSettings";
            this.metroTileSettings.UseSelectable = true;
            this.metroTileSettings.Click += new System.EventHandler(this.metroTileSettings_Click);
            // 
            // metroTileModelling
            // 
            this.metroTileModelling.ActiveControl = null;
            this.metroTileModelling.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileModelling, "metroTileModelling");
            this.metroTileModelling.Name = "metroTileModelling";
            this.metroTileModelling.UseSelectable = true;
            this.metroTileModelling.Click += new System.EventHandler(this.metroTileModeling_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTile1, "metroTile1");
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTileGit
            // 
            this.metroTileGit.ActiveControl = null;
            this.metroTileGit.BackColor = System.Drawing.Color.White;
            this.metroTileGit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileGit, "metroTileGit");
            this.metroTileGit.Name = "metroTileGit";
            this.metroTileGit.TileImage = global::glSDK.Properties.Resources.NewLogo;
            this.metroTileGit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileGit.UseSelectable = true;
            this.metroTileGit.Click += new System.EventHandler(this.metroTileGit_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroTileOther
            // 
            this.metroTileOther.ActiveControl = null;
            this.metroTileOther.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.metroTileOther, "metroTileOther");
            this.metroTileOther.Name = "metroTileOther";
            this.metroTileOther.UseSelectable = true;
            this.metroTileOther.Click += new System.EventHandler(this.metroTileOther_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.metroTileOther);
            this.Controls.Add(this.metroTileAbout);
            this.Controls.Add(this.metroTileManuals);
            this.Controls.Add(this.metroTileContent);
            this.Controls.Add(this.metroTileLinks);
            this.Controls.Add(this.metroTileModding);
            this.Controls.Add(this.metroTileCompiling);
            this.Controls.Add(this.metroTileTexturing);
            this.Controls.Add(this.metroTileMapping);
            this.Controls.Add(this.metroTileSettings);
            this.Controls.Add(this.metroTileModelling);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTileGit);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile metroTileAbout;
        private MetroFramework.Controls.MetroTile metroTileManuals;
        private MetroFramework.Controls.MetroTile metroTileContent;
        private MetroFramework.Controls.MetroTile metroTileLinks;
        private MetroFramework.Controls.MetroTile metroTileModding;
        private MetroFramework.Controls.MetroTile metroTileCompiling;
        private MetroFramework.Controls.MetroTile metroTileTexturing;
        private MetroFramework.Controls.MetroTile metroTileMapping;
        private MetroFramework.Controls.MetroTile metroTileSettings;
        private MetroFramework.Controls.MetroTile metroTileModelling;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTileGit;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile metroTileOther;
    }
}

