namespace glSDK.UI.LauncherForms
{
    partial class FrmModelling
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
            this.metroTileHLMV = new MetroFramework.Controls.MetroTile();
            this.metroTilestudiomdl = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileHLMV
            // 
            this.metroTileHLMV.ActiveControl = null;
            this.metroTileHLMV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileHLMV.Location = new System.Drawing.Point(23, 63);
            this.metroTileHLMV.Name = "metroTileHLMV";
            this.metroTileHLMV.Size = new System.Drawing.Size(90, 90);
            this.metroTileHLMV.TabIndex = 28;
            this.metroTileHLMV.Text = "Jed\'s HL model Viever";
            this.metroTileHLMV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileHLMV.UseSelectable = true;
            // 
            // metroTilestudiomdl
            // 
            this.metroTilestudiomdl.ActiveControl = null;
            this.metroTilestudiomdl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTilestudiomdl.Location = new System.Drawing.Point(119, 63);
            this.metroTilestudiomdl.Name = "metroTilestudiomdl";
            this.metroTilestudiomdl.Size = new System.Drawing.Size(90, 90);
            this.metroTilestudiomdl.TabIndex = 28;
            this.metroTilestudiomdl.Text = "studiomdl";
            this.metroTilestudiomdl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTilestudiomdl.UseSelectable = true;
            // 
            // FrmModelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 377);
            this.Controls.Add(this.metroTilestudiomdl);
            this.Controls.Add(this.metroTileHLMV);
            this.MaximizeBox = false;
            this.Name = "FrmModelling";
            this.Resizable = false;
            this.Text = "Modelling";
            this.Load += new System.EventHandler(this.FrmModelling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileHLMV;
        private MetroFramework.Controls.MetroTile metroTilestudiomdl;
    }
}