/*
*************************************************************************************
Tis file is distributed under MIT license:
*************************************************************************************
The MIT License (MIT)

Copyright © 2013-2014 EpicMorg

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ''Software''), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.", @"The MIT License (MIT)
*************************************************************************************
*/
namespace gSDK_Launcher {
    partial class frm_about {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_about = new System.Windows.Forms.Panel();
            this.lbl_libver = new System.Windows.Forms.Label();
            this.lblLibraryname = new System.Windows.Forms.Label();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.btn_credits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Location = new System.Drawing.Point(222, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Location = new System.Drawing.Point(246, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Enabled = false;
            this.pic_btn_exit.Location = new System.Drawing.Point(270, 12);
            this.pic_btn_exit.Visible = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(35, 13);
            this.lbl_title.Text = "About";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Location = new System.Drawing.Point(210, 142);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "OK";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_about
            // 
            this.panel_about.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.panel_about.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_about.Controls.Add(this.lbl_libver);
            this.panel_about.Controls.Add(this.lblLibraryname);
            this.panel_about.Controls.Add(this.lbl_credits);
            this.panel_about.Controls.Add(this.labelCopyright);
            this.panel_about.Controls.Add(this.labelVersion);
            this.panel_about.Controls.Add(this.labelProductName);
            this.panel_about.Location = new System.Drawing.Point(12, 34);
            this.panel_about.Name = "panel_about";
            this.panel_about.Size = new System.Drawing.Size(276, 102);
            this.panel_about.TabIndex = 9;
            // 
            // lbl_libver
            // 
            this.lbl_libver.AutoSize = true;
            this.lbl_libver.Location = new System.Drawing.Point(194, 40);
            this.lbl_libver.Name = "lbl_libver";
            this.lbl_libver.Size = new System.Drawing.Size(34, 13);
            this.lbl_libver.TabIndex = 12;
            this.lbl_libver.Text = "<ver>";
            // 
            // lblLibraryname
            // 
            this.lblLibraryname.AutoSize = true;
            this.lblLibraryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLibraryname.Location = new System.Drawing.Point(18, 40);
            this.lblLibraryname.Name = "lblLibraryname";
            this.lblLibraryname.Size = new System.Drawing.Size(92, 13);
            this.lblLibraryname.TabIndex = 11;
            this.lblLibraryname.Text = "<library_name>";
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(18, 40);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(0, 13);
            this.lbl_credits.TabIndex = 10;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyright.Location = new System.Drawing.Point(18, 68);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(43, 13);
            this.labelCopyright.TabIndex = 9;
            this.labelCopyright.Text = "<Copy>";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.Location = new System.Drawing.Point(194, 13);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(34, 13);
            this.labelVersion.TabIndex = 9;
            this.labelVersion.Text = "<ver>";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(18, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(103, 13);
            this.labelProductName.TabIndex = 9;
            this.labelProductName.Text = "<program_name>";
            // 
            // btn_credits
            // 
            this.btn_credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_credits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_credits.Location = new System.Drawing.Point(12, 142);
            this.btn_credits.Name = "btn_credits";
            this.btn_credits.Size = new System.Drawing.Size(75, 23);
            this.btn_credits.TabIndex = 7;
            this.btn_credits.Text = "Credits";
            this.btn_credits.UseVisualStyleBackColor = true;
            this.btn_credits.Click += new System.EventHandler(this.btn_credits_Click);
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 177);
            this.Controls.Add(this.btn_credits);
            this.Controls.Add(this.panel_about);
            this.Controls.Add(this.btn_close);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.panel_about, 0);
            this.Controls.SetChildIndex(this.btn_credits, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_about.ResumeLayout(false);
            this.panel_about.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close; 
        public System.Windows.Forms.Panel panel_about;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label lbl_credits;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label lbl_libver;
        private System.Windows.Forms.Label lblLibraryname;
        private System.Windows.Forms.Button btn_credits;
    }
}