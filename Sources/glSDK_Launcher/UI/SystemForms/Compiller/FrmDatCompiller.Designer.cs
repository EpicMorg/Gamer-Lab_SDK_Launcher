namespace glSDK.UI.SystemForms.Compiller
{
    partial class FrmDatCompiller
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
            this.metroLabelSelectProfile = new MetroFramework.Controls.MetroLabel();
            this.cmbProfile = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonEditProfile = new MetroFramework.Controls.MetroButton();
            this.metroLabelSelectMap = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxBrowse = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonBrowse = new MetroFramework.Controls.MetroButton();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.chkRun = new MetroFramework.Controls.MetroToggle();
            this.metroLabelRun = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabelSelectProfile
            // 
            this.metroLabelSelectProfile.AutoSize = true;
            this.metroLabelSelectProfile.Location = new System.Drawing.Point(23, 60);
            this.metroLabelSelectProfile.Name = "metroLabelSelectProfile";
            this.metroLabelSelectProfile.Size = new System.Drawing.Size(88, 19);
            this.metroLabelSelectProfile.TabIndex = 0;
            this.metroLabelSelectProfile.Text = "Select profile:";
            // 
            // cmbProfile
            // 
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.ItemHeight = 23;
            this.cmbProfile.Location = new System.Drawing.Point(23, 82);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(303, 29);
            this.cmbProfile.TabIndex = 1;
            this.cmbProfile.UseSelectable = true;
            // 
            // metroButtonEditProfile
            // 
            this.metroButtonEditProfile.Location = new System.Drawing.Point(332, 82);
            this.metroButtonEditProfile.Name = "metroButtonEditProfile";
            this.metroButtonEditProfile.Size = new System.Drawing.Size(75, 29);
            this.metroButtonEditProfile.TabIndex = 2;
            this.metroButtonEditProfile.Text = "Edit";
            this.metroButtonEditProfile.UseSelectable = true;
            this.metroButtonEditProfile.Click += new System.EventHandler(this.metroButtonEditProfile_Click);
            // 
            // metroLabelSelectMap
            // 
            this.metroLabelSelectMap.AutoSize = true;
            this.metroLabelSelectMap.Location = new System.Drawing.Point(23, 114);
            this.metroLabelSelectMap.Name = "metroLabelSelectMap";
            this.metroLabelSelectMap.Size = new System.Drawing.Size(144, 19);
            this.metroLabelSelectMap.TabIndex = 0;
            this.metroLabelSelectMap.Text = "Select map to compile:";
            // 
            // metroTextBoxBrowse
            // 
            this.metroTextBoxBrowse.Lines = new string[0];
            this.metroTextBoxBrowse.Location = new System.Drawing.Point(23, 136);
            this.metroTextBoxBrowse.MaxLength = 32767;
            this.metroTextBoxBrowse.Name = "metroTextBoxBrowse";
            
            this.metroTextBoxBrowse.ReadOnly = true;
            this.metroTextBoxBrowse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBrowse.SelectedText = "";
            this.metroTextBoxBrowse.Size = new System.Drawing.Size(303, 23);
            this.metroTextBoxBrowse.TabIndex = 3;
            this.metroTextBoxBrowse.UseSelectable = true;
            // 
            // metroButtonBrowse
            // 
            this.metroButtonBrowse.Location = new System.Drawing.Point(332, 136);
            this.metroButtonBrowse.Name = "metroButtonBrowse";
            this.metroButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.metroButtonBrowse.TabIndex = 4;
            this.metroButtonBrowse.Text = "Browse";
            this.metroButtonBrowse.UseSelectable = true;
            this.metroButtonBrowse.Click += new System.EventHandler(this.metroButtonBrowse_Click);
            // 
            // txtLog
            // 
            this.txtLog.Lines = new string[0];
            this.txtLog.Location = new System.Drawing.Point(23, 165);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";

            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLog.SelectedText = "";
            this.txtLog.Size = new System.Drawing.Size(384, 120);
            this.txtLog.TabIndex = 5;
            this.txtLog.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(23, 314);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(384, 40);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Run";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(327, 291);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(80, 17);
            this.chkRun.TabIndex = 7;
            this.chkRun.Text = "Off";
            this.chkRun.UseSelectable = true;
            // 
            // metroLabelRun
            // 
            this.metroLabelRun.AutoSize = true;
            this.metroLabelRun.Location = new System.Drawing.Point(23, 289);
            this.metroLabelRun.Name = "metroLabelRun";
            this.metroLabelRun.Size = new System.Drawing.Size(168, 19);
            this.metroLabelRun.TabIndex = 0;
            this.metroLabelRun.Text = "Run game after compilling:";
            // 
            // FrmDatCompiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 377);
            this.Controls.Add(this.chkRun);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.metroButtonBrowse);
            this.Controls.Add(this.metroTextBoxBrowse);
            this.Controls.Add(this.metroButtonEditProfile);
            this.Controls.Add(this.cmbProfile);
            this.Controls.Add(this.metroLabelRun);
            this.Controls.Add(this.metroLabelSelectMap);
            this.Controls.Add(this.metroLabelSelectProfile);
            this.MaximizeBox = false;
            this.Name = "FrmDatCompiller";
            this.Resizable = false;
            this.Text = "Compiller";
            this.Load += new System.EventHandler(this.FrmDatCompiller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelSelectProfile;
        private MetroFramework.Controls.MetroComboBox cmbProfile;
        private MetroFramework.Controls.MetroButton metroButtonEditProfile;
        private MetroFramework.Controls.MetroLabel metroLabelSelectMap;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBrowse;
        private MetroFramework.Controls.MetroButton metroButtonBrowse;
        private MetroFramework.Controls.MetroTextBox txtLog;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroToggle chkRun;
        private MetroFramework.Controls.MetroLabel metroLabelRun;
    }
}