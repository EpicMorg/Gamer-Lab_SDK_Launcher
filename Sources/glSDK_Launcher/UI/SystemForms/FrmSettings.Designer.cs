namespace glSDK.UI.SystemForms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.metroButtonReset = new System.Windows.Forms.PictureBox();
            this.metroButtonSave = new System.Windows.Forms.PictureBox();
            this.metroToggleLog = new MetroFramework.Controls.MetroToggle();
            this.metroComboBoxShadow = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelLog = new MetroFramework.Controls.MetroLabel();
            this.metroLabelShadow = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTheme = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxSkin = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelSkin = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxLang = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelLang = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroButtonReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroButtonSave)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonReset
            // 
            this.metroButtonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonReset.Image = global::glSDK.Properties.Resources.reset_dark;
            this.metroButtonReset.Location = new System.Drawing.Point(249, 278);
            this.metroButtonReset.Name = "metroButtonReset";
            this.metroButtonReset.Size = new System.Drawing.Size(76, 76);
            this.metroButtonReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.metroButtonReset.TabIndex = 4;
            this.metroButtonReset.TabStop = false;
            this.metroButtonReset.Click += new System.EventHandler(this.metroButtonReset_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonSave.Image = global::glSDK.Properties.Resources.save_dark;
            this.metroButtonSave.Location = new System.Drawing.Point(331, 278);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(76, 76);
            this.metroButtonSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.metroButtonSave.TabIndex = 4;
            this.metroButtonSave.TabStop = false;
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroToggleLog
            // 
            this.metroToggleLog.AutoSize = true;
            this.metroToggleLog.Enabled = false;
            this.metroToggleLog.Location = new System.Drawing.Point(163, 280);
            this.metroToggleLog.Name = "metroToggleLog";
            this.metroToggleLog.Size = new System.Drawing.Size(80, 17);
            this.metroToggleLog.TabIndex = 2;
            this.metroToggleLog.Text = "Off";
            this.metroToggleLog.UseSelectable = true;
            // 
            // metroComboBoxShadow
            // 
            this.metroComboBoxShadow.FormattingEnabled = true;
            this.metroComboBoxShadow.ItemHeight = 23;
            this.metroComboBoxShadow.Location = new System.Drawing.Point(23, 190);
            this.metroComboBoxShadow.Name = "metroComboBoxShadow";
            this.metroComboBoxShadow.Size = new System.Drawing.Size(384, 29);
            this.metroComboBoxShadow.TabIndex = 1;
            this.metroComboBoxShadow.UseSelectable = true;
            // 
            // metroComboBoxTheme
            // 
            this.metroComboBoxTheme.FormattingEnabled = true;
            this.metroComboBoxTheme.ItemHeight = 23;
            this.metroComboBoxTheme.Location = new System.Drawing.Point(23, 136);
            this.metroComboBoxTheme.Name = "metroComboBoxTheme";
            this.metroComboBoxTheme.Size = new System.Drawing.Size(384, 29);
            this.metroComboBoxTheme.TabIndex = 1;
            this.metroComboBoxTheme.UseSelectable = true;
            // 
            // metroLabelLog
            // 
            this.metroLabelLog.AutoSize = true;
            this.metroLabelLog.Location = new System.Drawing.Point(23, 278);
            this.metroLabelLog.Name = "metroLabelLog";
            this.metroLabelLog.Size = new System.Drawing.Size(34, 19);
            this.metroLabelLog.TabIndex = 0;
            this.metroLabelLog.Text = "Log:";
            // 
            // metroLabelShadow
            // 
            this.metroLabelShadow.AutoSize = true;
            this.metroLabelShadow.Location = new System.Drawing.Point(23, 168);
            this.metroLabelShadow.Name = "metroLabelShadow";
            this.metroLabelShadow.Size = new System.Drawing.Size(87, 19);
            this.metroLabelShadow.TabIndex = 0;
            this.metroLabelShadow.Text = "Shadow type:";
            // 
            // metroLabelTheme
            // 
            this.metroLabelTheme.AutoSize = true;
            this.metroLabelTheme.Location = new System.Drawing.Point(23, 114);
            this.metroLabelTheme.Name = "metroLabelTheme";
            this.metroLabelTheme.Size = new System.Drawing.Size(52, 19);
            this.metroLabelTheme.TabIndex = 0;
            this.metroLabelTheme.Text = "Theme:";
            // 
            // metroComboBoxSkin
            // 
            this.metroComboBoxSkin.FormattingEnabled = true;
            this.metroComboBoxSkin.ItemHeight = 23;
            this.metroComboBoxSkin.Location = new System.Drawing.Point(23, 82);
            this.metroComboBoxSkin.Name = "metroComboBoxSkin";
            this.metroComboBoxSkin.Size = new System.Drawing.Size(384, 29);
            this.metroComboBoxSkin.TabIndex = 1;
            this.metroComboBoxSkin.UseSelectable = true;
            // 
            // metroLabelSkin
            // 
            this.metroLabelSkin.AutoSize = true;
            this.metroLabelSkin.Location = new System.Drawing.Point(23, 60);
            this.metroLabelSkin.Name = "metroLabelSkin";
            this.metroLabelSkin.Size = new System.Drawing.Size(35, 19);
            this.metroLabelSkin.TabIndex = 0;
            this.metroLabelSkin.Text = "Skin:";
            // 
            // metroComboBoxLang
            // 
            this.metroComboBoxLang.FormattingEnabled = true;
            this.metroComboBoxLang.ItemHeight = 23;
            this.metroComboBoxLang.Location = new System.Drawing.Point(23, 244);
            this.metroComboBoxLang.Name = "metroComboBoxLang";
            this.metroComboBoxLang.Size = new System.Drawing.Size(384, 29);
            this.metroComboBoxLang.TabIndex = 6;
            this.metroComboBoxLang.UseSelectable = true;
            // 
            // metroLabelLang
            // 
            this.metroLabelLang.AutoSize = true;
            this.metroLabelLang.Location = new System.Drawing.Point(23, 222);
            this.metroLabelLang.Name = "metroLabelLang";
            this.metroLabelLang.Size = new System.Drawing.Size(69, 19);
            this.metroLabelLang.TabIndex = 5;
            this.metroLabelLang.Text = "Language:";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 377);
            this.Controls.Add(this.metroComboBoxLang);
            this.Controls.Add(this.metroLabelLang);
            this.Controls.Add(this.metroButtonReset);
            this.Controls.Add(this.metroButtonSave);
            this.Controls.Add(this.metroToggleLog);
            this.Controls.Add(this.metroComboBoxShadow);
            this.Controls.Add(this.metroComboBoxTheme);
            this.Controls.Add(this.metroLabelLog);
            this.Controls.Add(this.metroLabelShadow);
            this.Controls.Add(this.metroLabelTheme);
            this.Controls.Add(this.metroComboBoxSkin);
            this.Controls.Add(this.metroLabelSkin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Resizable = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroButtonReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroButtonSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelSkin;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSkin;
        private MetroFramework.Controls.MetroLabel metroLabelTheme;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTheme;
        private MetroFramework.Controls.MetroLabel metroLabelLog;
        private MetroFramework.Controls.MetroToggle metroToggleLog;
        private System.Windows.Forms.PictureBox metroButtonSave;
        private System.Windows.Forms.PictureBox metroButtonReset;
        private MetroFramework.Controls.MetroLabel metroLabelShadow;
        private MetroFramework.Controls.MetroComboBox metroComboBoxShadow;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLang;
        private MetroFramework.Controls.MetroLabel metroLabelLang;
    }
}