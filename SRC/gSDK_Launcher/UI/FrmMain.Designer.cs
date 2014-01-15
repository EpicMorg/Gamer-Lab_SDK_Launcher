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
    partial class FrmMain {
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.listv_programs = new System.Windows.Forms.ListView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_additem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Location = new System.Drawing.Point(331, 12);
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Location = new System.Drawing.Point(355, 12);
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new System.Drawing.Point(379, 12);
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(136, 13);
            this.lbl_title.Text = "GoldSource SDK Launcher";
            // 
            // listv_programs
            // 
            this.listv_programs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listv_programs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.listv_programs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listv_programs.ForeColor = System.Drawing.Color.White;
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.listv_programs.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listv_programs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listv_programs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listv_programs.Location = new System.Drawing.Point(12, 43);
            this.listv_programs.Name = "listv_programs";
            this.listv_programs.Size = new System.Drawing.Size(386, 180);
            this.listv_programs.TabIndex = 7;
            this.listv_programs.UseCompatibleStateImageBehavior = false;
            this.listv_programs.View = System.Windows.Forms.View.Tile;
            this.listv_programs.DoubleClick += new System.EventHandler(this.listv_programs_DoubleClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(322, 229);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 25);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Close";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.btn_about.Location = new System.Drawing.Point(12, 229);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(93, 25);
            this.btn_about.TabIndex = 8;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.btn_settings.Location = new System.Drawing.Point(111, 229);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(100, 25);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.Text = "Config";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_additem
            // 
            this.btn_additem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_additem.FlatAppearance.BorderSize = 0;
            this.btn_additem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_additem.Location = new System.Drawing.Point(219, 229);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(97, 25);
            this.btn_additem.TabIndex = 8;
            this.btn_additem.Text = "Edit menu";
            this.btn_additem.UseVisualStyleBackColor = true;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.btn_additem);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listv_programs);
            this.MinimumSize = new System.Drawing.Size(410, 266);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoldSource SDK Launcher";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.listv_programs, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_about, 0);
            this.Controls.SetChildIndex(this.btn_settings, 0);
            this.Controls.SetChildIndex(this.btn_additem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listv_programs;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_additem;
 

       


    }
}