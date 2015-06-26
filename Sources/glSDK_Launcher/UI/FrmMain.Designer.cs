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
            this.metroTileAbout.Location = new System.Drawing.Point(311, 255);
            this.metroTileAbout.Name = "metroTileAbout";
            this.metroTileAbout.Size = new System.Drawing.Size(90, 90);
            this.metroTileAbout.TabIndex = 14;
            this.metroTileAbout.Text = "About";
            this.metroTileAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileAbout.UseSelectable = true;
            this.metroTileAbout.Click += new System.EventHandler(this.metroTileAbout_Click);
            // 
            // metroTileManuals
            // 
            this.metroTileManuals.ActiveControl = null;
            this.metroTileManuals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileManuals.Location = new System.Drawing.Point(215, 255);
            this.metroTileManuals.Name = "metroTileManuals";
            this.metroTileManuals.Size = new System.Drawing.Size(90, 42);
            this.metroTileManuals.TabIndex = 15;
            this.metroTileManuals.Tag = "";
            this.metroTileManuals.Text = "Manuals";
            this.metroTileManuals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileManuals.UseSelectable = true;
            this.metroTileManuals.Click += new System.EventHandler(this.metroTileManuals_Click);
            // 
            // metroTileContent
            // 
            this.metroTileContent.ActiveControl = null;
            this.metroTileContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileContent.Location = new System.Drawing.Point(311, 63);
            this.metroTileContent.Name = "metroTileContent";
            this.metroTileContent.Size = new System.Drawing.Size(90, 90);
            this.metroTileContent.TabIndex = 16;
            this.metroTileContent.Text = "Content";
            this.metroTileContent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileContent.UseSelectable = true;
            this.metroTileContent.Click += new System.EventHandler(this.metroTileContent_Click);
            // 
            // metroTileLinks
            // 
            this.metroTileLinks.ActiveControl = null;
            this.metroTileLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileLinks.Location = new System.Drawing.Point(215, 303);
            this.metroTileLinks.Name = "metroTileLinks";
            this.metroTileLinks.Size = new System.Drawing.Size(90, 42);
            this.metroTileLinks.TabIndex = 17;
            this.metroTileLinks.Text = "Links";
            this.metroTileLinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLinks.TileImage = global::glSDK.Properties.Resources.internet_dark;
            this.metroTileLinks.UseSelectable = true;
            this.metroTileLinks.Click += new System.EventHandler(this.metroTileFemLinks_Click);
            // 
            // metroTileModding
            // 
            this.metroTileModding.ActiveControl = null;
            this.metroTileModding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileModding.Location = new System.Drawing.Point(215, 159);
            this.metroTileModding.Name = "metroTileModding";
            this.metroTileModding.Size = new System.Drawing.Size(90, 90);
            this.metroTileModding.TabIndex = 18;
            this.metroTileModding.Text = "Modding";
            this.metroTileModding.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileModding.UseSelectable = true;
            this.metroTileModding.Click += new System.EventHandler(this.metroTileModing_Click);
            // 
            // metroTileCompiling
            // 
            this.metroTileCompiling.ActiveControl = null;
            this.metroTileCompiling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileCompiling.Location = new System.Drawing.Point(215, 63);
            this.metroTileCompiling.Name = "metroTileCompiling";
            this.metroTileCompiling.Size = new System.Drawing.Size(90, 90);
            this.metroTileCompiling.TabIndex = 19;
            this.metroTileCompiling.Text = "Compiling";
            this.metroTileCompiling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileCompiling.UseSelectable = true;
            this.metroTileCompiling.Click += new System.EventHandler(this.metroTileCompiling_Click);
            // 
            // metroTileTexturing
            // 
            this.metroTileTexturing.ActiveControl = null;
            this.metroTileTexturing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileTexturing.Location = new System.Drawing.Point(119, 159);
            this.metroTileTexturing.Name = "metroTileTexturing";
            this.metroTileTexturing.Size = new System.Drawing.Size(90, 90);
            this.metroTileTexturing.TabIndex = 20;
            this.metroTileTexturing.Text = "Texturing";
            this.metroTileTexturing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileTexturing.UseSelectable = true;
            this.metroTileTexturing.Click += new System.EventHandler(this.metroTileTexturing_Click);
            // 
            // metroTileMapping
            // 
            this.metroTileMapping.ActiveControl = null;
            this.metroTileMapping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileMapping.Location = new System.Drawing.Point(119, 63);
            this.metroTileMapping.Name = "metroTileMapping";
            this.metroTileMapping.Size = new System.Drawing.Size(90, 90);
            this.metroTileMapping.TabIndex = 21;
            this.metroTileMapping.Text = "Mapping";
            this.metroTileMapping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileMapping.UseSelectable = true;
            this.metroTileMapping.Click += new System.EventHandler(this.metroTileMapping_Click);
            // 
            // metroTileSettings
            // 
            this.metroTileSettings.ActiveControl = null;
            this.metroTileSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileSettings.Location = new System.Drawing.Point(23, 255);
            this.metroTileSettings.Name = "metroTileSettings";
            this.metroTileSettings.Size = new System.Drawing.Size(90, 90);
            this.metroTileSettings.TabIndex = 22;
            this.metroTileSettings.Text = "Settings";
            this.metroTileSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileSettings.UseSelectable = true;
            this.metroTileSettings.Click += new System.EventHandler(this.metroTileSettings_Click);
            // 
            // metroTileModelling
            // 
            this.metroTileModelling.ActiveControl = null;
            this.metroTileModelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileModelling.Location = new System.Drawing.Point(23, 159);
            this.metroTileModelling.Name = "metroTileModelling";
            this.metroTileModelling.Size = new System.Drawing.Size(90, 90);
            this.metroTileModelling.TabIndex = 23;
            this.metroTileModelling.Text = "Modelling";
            this.metroTileModelling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileModelling.UseSelectable = true;
            this.metroTileModelling.Click += new System.EventHandler(this.metroTileModeling_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(23, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 90);
            this.metroTile1.TabIndex = 24;
            this.metroTile1.Text = "Editors";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTileGit
            // 
            this.metroTileGit.ActiveControl = null;
            this.metroTileGit.BackColor = System.Drawing.Color.White;
            this.metroTileGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileGit.Location = new System.Drawing.Point(119, 255);
            this.metroTileGit.Name = "metroTileGit";
            this.metroTileGit.Size = new System.Drawing.Size(90, 90);
            this.metroTileGit.TabIndex = 25;
            this.metroTileGit.Text = "Get sources";
            this.metroTileGit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.metroTileOther.Location = new System.Drawing.Point(311, 159);
            this.metroTileOther.Name = "metroTileOther";
            this.metroTileOther.Size = new System.Drawing.Size(90, 90);
            this.metroTileOther.TabIndex = 26;
            this.metroTileOther.Text = "Other";
            this.metroTileOther.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileOther.UseSelectable = true;
            this.metroTileOther.Click += new System.EventHandler(this.metroTileOther_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(430, 377);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 40);
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "GoldSRC SDK Launcher";
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

