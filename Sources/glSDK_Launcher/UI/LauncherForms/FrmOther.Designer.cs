namespace glSDK.UI.LauncherForms
{
    partial class FrmOther
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
            this.metroTileuneed1 = new MetroFramework.Controls.MetroTile();
            this.metroTileuneed2 = new MetroFramework.Controls.MetroTile();
            this.metroTileuniconv = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileuneed1
            // 
            this.metroTileuneed1.ActiveControl = null;
            this.metroTileuneed1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileuneed1.Location = new System.Drawing.Point(23, 63);
            this.metroTileuneed1.Name = "metroTileuneed1";
            this.metroTileuneed1.Size = new System.Drawing.Size(90, 90);
            this.metroTileuneed1.TabIndex = 29;
            this.metroTileuneed1.Text = "Uneed";
            this.metroTileuneed1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileuneed1.UseSelectable = true;
            // 
            // metroTileuneed2
            // 
            this.metroTileuneed2.ActiveControl = null;
            this.metroTileuneed2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileuneed2.Location = new System.Drawing.Point(119, 63);
            this.metroTileuneed2.Name = "metroTileuneed2";
            this.metroTileuneed2.Size = new System.Drawing.Size(90, 90);
            this.metroTileuneed2.TabIndex = 29;
            this.metroTileuneed2.Text = "uneed2";
            this.metroTileuneed2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileuneed2.UseSelectable = true;
            // 
            // metroTileuniconv
            // 
            this.metroTileuniconv.ActiveControl = null;
            this.metroTileuniconv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileuniconv.Location = new System.Drawing.Point(215, 63);
            this.metroTileuniconv.Name = "metroTileuniconv";
            this.metroTileuniconv.Size = new System.Drawing.Size(90, 90);
            this.metroTileuniconv.TabIndex = 29;
            this.metroTileuniconv.Text = "Unit converter";
            this.metroTileuniconv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileuniconv.UseSelectable = true;
            // 
            // FrmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 377);
            this.Controls.Add(this.metroTileuniconv);
            this.Controls.Add(this.metroTileuneed2);
            this.Controls.Add(this.metroTileuneed1);
            this.MaximizeBox = false;
            this.Name = "FrmOther";
            this.Resizable = false;
            this.Text = "Other";
            this.Load += new System.EventHandler(this.FrmOther_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileuneed1;
        private MetroFramework.Controls.MetroTile metroTileuneed2;
        private MetroFramework.Controls.MetroTile metroTileuniconv;
    }
}