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

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace gSDK_Launcher {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("");
            listv_programs = new ListView();
            btn_exit = new Button();
            btn_about = new Button();
            btn_settings = new Button();
            btn_additem = new Button();
            ((ISupportInitialize)(pic_btn_min)).BeginInit();
            ((ISupportInitialize)(pic_btn_max)).BeginInit();
            ((ISupportInitialize)(pic_btn_exit)).BeginInit();
            ((ISupportInitialize)(pic_logo)).BeginInit();
            SuspendLayout();
            // 
            // pic_btn_min
            // 
            pic_btn_min.Location = new Point(331, 12);
            // 
            // pic_btn_max
            // 
            pic_btn_max.Location = new Point(355, 12);
            // 
            // pic_btn_exit
            // 
            pic_btn_exit.Location = new Point(379, 12);
            // 
            // lbl_title
            // 
            lbl_title.Size = new Size(136, 13);
            lbl_title.Text = "GoldSource SDK Launcher";
            // 
            // listv_programs
            // 
            listv_programs.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            listv_programs.BackColor = Color.FromArgb(62, 70, 55);
            listv_programs.BorderStyle = BorderStyle.FixedSingle;
            listv_programs.ForeColor = Color.White;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listv_programs.Groups.AddRange(new ListViewGroup[] {
            listViewGroup1});
            listv_programs.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listv_programs.Items.AddRange(new ListViewItem[] {
            listViewItem1});
            listv_programs.Location = new Point(12, 43);
            listv_programs.Name = "listv_programs";
            listv_programs.Size = new Size(386, 180);
            listv_programs.TabIndex = 7;
            listv_programs.UseCompatibleStateImageBehavior = false;
            listv_programs.View = View.Tile;
            listv_programs.DoubleClick += listv_programs_DoubleClick;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Popup;
            btn_exit.Location = new Point(322, 229);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 25);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Close";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_about
            // 
            btn_about.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Popup;
            btn_about.ForeColor = Color.FromArgb(136, 145, 128);
            btn_about.Location = new Point(12, 229);
            btn_about.Name = "btn_about";
            btn_about.Size = new Size(93, 25);
            btn_about.TabIndex = 8;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = true;
            btn_about.Click += btn_about_Click;
            // 
            // btn_settings
            // 
            btn_settings.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Popup;
            btn_settings.ForeColor = Color.FromArgb(136, 145, 128);
            btn_settings.Location = new Point(111, 229);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(100, 25);
            btn_settings.TabIndex = 8;
            btn_settings.Text = "Config";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_additem
            // 
            btn_additem.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            btn_additem.FlatAppearance.BorderSize = 0;
            btn_additem.FlatStyle = FlatStyle.Popup;
            btn_additem.Location = new Point(219, 229);
            btn_additem.Name = "btn_additem";
            btn_additem.Size = new Size(97, 25);
            btn_additem.TabIndex = 8;
            btn_additem.Text = "Edit menu";
            btn_additem.UseVisualStyleBackColor = true;
            btn_additem.Click += btn_additem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            ClientSize = new Size(410, 266);
            Controls.Add(btn_additem);
            Controls.Add(btn_settings);
            Controls.Add(btn_about);
            Controls.Add(btn_exit);
            Controls.Add(listv_programs);
            MinimumSize = new Size(410, 266);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GoldSource SDK Launcher";
            Load += frm_main_Load;
            Controls.SetChildIndex(lbl_title, 0);
            Controls.SetChildIndex(pic_logo, 0);
            Controls.SetChildIndex(pic_btn_min, 0);
            Controls.SetChildIndex(pic_btn_exit, 0);
            Controls.SetChildIndex(pic_btn_max, 0);
            Controls.SetChildIndex(listv_programs, 0);
            Controls.SetChildIndex(btn_exit, 0);
            Controls.SetChildIndex(btn_about, 0);
            Controls.SetChildIndex(btn_settings, 0);
            Controls.SetChildIndex(btn_additem, 0);
            ((ISupportInitialize)(pic_btn_min)).EndInit();
            ((ISupportInitialize)(pic_btn_max)).EndInit();
            ((ISupportInitialize)(pic_btn_exit)).EndInit();
            ((ISupportInitialize)(pic_logo)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private ListView listv_programs;
        private Button btn_exit;
        private Button btn_about;
        private Button btn_settings;
        private Button btn_additem;
    }
}