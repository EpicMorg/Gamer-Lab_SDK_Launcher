namespace glSDK.UI
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButtonCredits = new MetroFramework.Controls.MetroButton();
            this.metroButtonOther = new MetroFramework.Controls.MetroButton();
            this.metroLabelCopy = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVer = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::glSDK.Properties.Resources.NewLogo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroButtonCredits
            // 
            this.metroButtonCredits.Location = new System.Drawing.Point(222, 329);
            this.metroButtonCredits.Name = "metroButtonCredits";
            this.metroButtonCredits.Size = new System.Drawing.Size(145, 23);
            this.metroButtonCredits.TabIndex = 2;
            this.metroButtonCredits.Text = "Credits";
            this.metroButtonCredits.UseSelectable = true;
            this.metroButtonCredits.Click += new System.EventHandler(this.metroButtonCredits_Click);
            // 
            // metroButtonOther
            // 
            this.metroButtonOther.Location = new System.Drawing.Point(23, 329);
            this.metroButtonOther.Name = "metroButtonOther";
            this.metroButtonOther.Size = new System.Drawing.Size(145, 23);
            this.metroButtonOther.TabIndex = 3;
            this.metroButtonOther.Text = "Third-Party Software ";
            this.metroButtonOther.UseSelectable = true;
            this.metroButtonOther.Click += new System.EventHandler(this.metroButtonOther_Click);
            // 
            // metroLabelCopy
            // 
            this.metroLabelCopy.AutoSize = true;
            this.metroLabelCopy.Location = new System.Drawing.Point(23, 307);
            this.metroLabelCopy.Name = "metroLabelCopy";
            this.metroLabelCopy.Size = new System.Drawing.Size(63, 19);
            this.metroLabelCopy.TabIndex = 4;
            this.metroLabelCopy.Text = "< copy >";
            // 
            // metroLabelVer
            // 
            this.metroLabelVer.AutoSize = true;
            this.metroLabelVer.Location = new System.Drawing.Point(222, 307);
            this.metroLabelVer.Name = "metroLabelVer";
            this.metroLabelVer.Size = new System.Drawing.Size(53, 19);
            this.metroLabelVer.TabIndex = 4;
            this.metroLabelVer.Text = "< ver >";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 375);
            this.Controls.Add(this.metroLabelVer);
            this.Controls.Add(this.metroLabelCopy);
            this.Controls.Add(this.metroButtonOther);
            this.Controls.Add(this.metroButtonCredits);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "About";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButtonCredits;
        private MetroFramework.Controls.MetroButton metroButtonOther;
        private MetroFramework.Controls.MetroLabel metroLabelCopy;
        private MetroFramework.Controls.MetroLabel metroLabelVer;
    }
}