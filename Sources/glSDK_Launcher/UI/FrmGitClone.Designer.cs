namespace glSDK.UI
{
    partial class FrmGitClone
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
            this.metroBtnGitClone = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxGit = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroBtnGitClone
            // 
            this.metroBtnGitClone.ActiveControl = null;
            this.metroBtnGitClone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroBtnGitClone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroBtnGitClone.Location = new System.Drawing.Point(51, 180);
            this.metroBtnGitClone.Name = "metroBtnGitClone";
            this.metroBtnGitClone.Size = new System.Drawing.Size(411, 40);
            this.metroBtnGitClone.TabIndex = 7;
            this.metroBtnGitClone.Text = "Clone";
            this.metroBtnGitClone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroBtnGitClone.UseSelectable = true;
            this.metroBtnGitClone.Click += new System.EventHandler(this.metroBtnGitClone_Click);
            // 
            // metroComboBoxGit
            // 
            this.metroComboBoxGit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxGit.ItemHeight = 23;
            this.metroComboBoxGit.Items.AddRange(new object[] {
            "Launcher (EpicMorg Git, Official)",
            "Half-Life SDK (Steam, Official)",
            "Half-Life SDK (Valve Git, Official)",
            "Source SDK (Valve Git, Official)",
            "OpenVR SDK (Valve Git, Official)"});
            this.metroComboBoxGit.Location = new System.Drawing.Point(51, 145);
            this.metroComboBoxGit.Name = "metroComboBoxGit";
            this.metroComboBoxGit.Size = new System.Drawing.Size(411, 29);
            this.metroComboBoxGit.TabIndex = 6;
            this.metroComboBoxGit.UseSelectable = true;
            // 
            // FrmGitClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 279);
            this.Controls.Add(this.metroBtnGitClone);
            this.Controls.Add(this.metroComboBoxGit);
            this.MaximizeBox = false;
            this.Name = "FrmGitClone";
            this.Resizable = false;
            this.Text = "FrmGitClone";
            this.Load += new System.EventHandler(this.FrmGitClone_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroBtnGitClone;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGit;
    }
}