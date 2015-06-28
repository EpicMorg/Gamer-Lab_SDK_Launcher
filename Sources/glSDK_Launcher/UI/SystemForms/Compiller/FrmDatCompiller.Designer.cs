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
            this.metroComboBoxProfile = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonEditProfile = new MetroFramework.Controls.MetroButton();
            this.metroLabelSelectMap = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxBrowse = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonBrowse = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxLog = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroToggleRun = new MetroFramework.Controls.MetroToggle();
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
            // metroComboBoxProfile
            // 
            this.metroComboBoxProfile.FormattingEnabled = true;
            this.metroComboBoxProfile.ItemHeight = 23;
            this.metroComboBoxProfile.Location = new System.Drawing.Point(23, 82);
            this.metroComboBoxProfile.Name = "metroComboBoxProfile";
            this.metroComboBoxProfile.Size = new System.Drawing.Size(303, 29);
            this.metroComboBoxProfile.TabIndex = 1;
            this.metroComboBoxProfile.UseSelectable = true;
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
            this.metroTextBoxBrowse.PasswordChar = '\0';
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
            // metroTextBoxLog
            // 
            this.metroTextBoxLog.Lines = new string[0];
            this.metroTextBoxLog.Location = new System.Drawing.Point(23, 165);
            this.metroTextBoxLog.MaxLength = 32767;
            this.metroTextBoxLog.Multiline = true;
            this.metroTextBoxLog.Name = "metroTextBoxLog";
            this.metroTextBoxLog.PasswordChar = '\0';
            this.metroTextBoxLog.ReadOnly = true;
            this.metroTextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLog.SelectedText = "";
            this.metroTextBoxLog.Size = new System.Drawing.Size(384, 120);
            this.metroTextBoxLog.TabIndex = 5;
            this.metroTextBoxLog.UseSelectable = true;
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
            // 
            // metroToggleRun
            // 
            this.metroToggleRun.AutoSize = true;
            this.metroToggleRun.Location = new System.Drawing.Point(327, 291);
            this.metroToggleRun.Name = "metroToggleRun";
            this.metroToggleRun.Size = new System.Drawing.Size(80, 17);
            this.metroToggleRun.TabIndex = 7;
            this.metroToggleRun.Text = "Off";
            this.metroToggleRun.UseSelectable = true;
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
            this.Controls.Add(this.metroToggleRun);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTextBoxLog);
            this.Controls.Add(this.metroButtonBrowse);
            this.Controls.Add(this.metroTextBoxBrowse);
            this.Controls.Add(this.metroButtonEditProfile);
            this.Controls.Add(this.metroComboBoxProfile);
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
        private MetroFramework.Controls.MetroComboBox metroComboBoxProfile;
        private MetroFramework.Controls.MetroButton metroButtonEditProfile;
        private MetroFramework.Controls.MetroLabel metroLabelSelectMap;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBrowse;
        private MetroFramework.Controls.MetroButton metroButtonBrowse;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLog;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroToggle metroToggleRun;
        private MetroFramework.Controls.MetroLabel metroLabelRun;
    }
}