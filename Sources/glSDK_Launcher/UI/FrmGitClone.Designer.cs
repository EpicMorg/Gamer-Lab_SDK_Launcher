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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGitClone));
            this.metroBtnGitClone = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxGit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelInfo = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroBtnGitClone
            // 
            this.metroBtnGitClone.ActiveControl = null;
            resources.ApplyResources(this.metroBtnGitClone, "metroBtnGitClone");
            this.metroBtnGitClone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroBtnGitClone.Name = "metroBtnGitClone";
            this.metroBtnGitClone.UseSelectable = true;
            this.metroBtnGitClone.Click += new System.EventHandler(this.metroBtnGitClone_Click);
            // 
            // metroComboBoxGit
            // 
            resources.ApplyResources(this.metroComboBoxGit, "metroComboBoxGit");
            this.metroComboBoxGit.Items.AddRange(new object[] {
            resources.GetString("metroComboBoxGit.Items"),
            resources.GetString("metroComboBoxGit.Items1"),
            resources.GetString("metroComboBoxGit.Items2"),
            resources.GetString("metroComboBoxGit.Items3"),
            resources.GetString("metroComboBoxGit.Items4")});
            this.metroComboBoxGit.Name = "metroComboBoxGit";
            this.metroComboBoxGit.UseSelectable = true;
            this.metroComboBoxGit.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxGit_SelectedIndexChanged);
            // 
            // metroLabelInfo
            // 
            resources.ApplyResources(this.metroLabelInfo, "metroLabelInfo");
            this.metroLabelInfo.Name = "metroLabelInfo";
            this.metroLabelInfo.WrapToLine = true;
            // 
            // metroProgressBar
            // 
            resources.ApplyResources(this.metroProgressBar, "metroProgressBar");
            this.metroProgressBar.Name = "metroProgressBar";
            // 
            // timer
            // 
            this.timer.Interval = 1500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmGitClone
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroProgressBar);
            this.Controls.Add(this.metroLabelInfo);
            this.Controls.Add(this.metroBtnGitClone);
            this.Controls.Add(this.metroComboBoxGit);
            this.MaximizeBox = false;
            this.Name = "FrmGitClone";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FrmGitClone_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroBtnGitClone;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGit;
        private MetroFramework.Controls.MetroLabel metroLabelInfo;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.Timer timer;
    }
}