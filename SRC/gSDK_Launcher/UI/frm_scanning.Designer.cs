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
    partial class frm_scanning {
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
            this.components = new System.ComponentModel.Container();
            this.lbl_prepearing_text = new System.Windows.Forms.Label();
            this.progressbar_prepearing = new System.Windows.Forms.ProgressBar();
            this.timer_updating = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Enabled = false;
            this.pic_btn_min.Location = new System.Drawing.Point(302, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Enabled = false;
            this.pic_btn_max.Location = new System.Drawing.Point(326, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Enabled = false;
            this.pic_btn_exit.Location = new System.Drawing.Point(350, 12);
            this.pic_btn_exit.Visible = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(70, 13);
            this.lbl_title.Text = "Please wait...";
            // 
            // lbl_prepearing_text
            // 
            this.lbl_prepearing_text.AutoSize = true;
            this.lbl_prepearing_text.Location = new System.Drawing.Point(9, 42);
            this.lbl_prepearing_text.Name = "lbl_prepearing_text";
            this.lbl_prepearing_text.Size = new System.Drawing.Size(127, 13);
            this.lbl_prepearing_text.TabIndex = 7;
            this.lbl_prepearing_text.Text = "Please wait.. Prepearing..";
            // 
            // progressbar_prepearing
            // 
            this.progressbar_prepearing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressbar_prepearing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.progressbar_prepearing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(80)))));
            this.progressbar_prepearing.Location = new System.Drawing.Point(12, 58);
            this.progressbar_prepearing.Name = "progressbar_prepearing";
            this.progressbar_prepearing.Size = new System.Drawing.Size(356, 23);
            this.progressbar_prepearing.TabIndex = 8;
            this.progressbar_prepearing.UseWaitCursor = true;
            this.progressbar_prepearing.Value = 100;
            // 
            // timer_updating
            // 
            this.timer_updating.Interval = 3000;
            this.timer_updating.Tick += new System.EventHandler(this.timer_updating_Tick);
            // 
            // frm_scanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 112);
            this.Controls.Add(this.progressbar_prepearing);
            this.Controls.Add(this.lbl_prepearing_text);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 112);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 112);
            this.Name = "frm_scanning";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please wait...";
            this.Load += new System.EventHandler(this.frm_scanning_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.lbl_prepearing_text, 0);
            this.Controls.SetChildIndex(this.progressbar_prepearing, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prepearing_text;
        private System.Windows.Forms.ProgressBar progressbar_prepearing;
        private System.Windows.Forms.Timer timer_updating;
       
    }
}