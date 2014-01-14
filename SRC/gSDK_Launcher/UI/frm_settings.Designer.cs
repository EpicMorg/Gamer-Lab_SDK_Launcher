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
    partial class frm_settings {
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
            this.btn_rescan = new System.Windows.Forms.Button();
            this.lbl_def_lang = new System.Windows.Forms.Label();
            this.panel_config = new System.Windows.Forms.Panel();
            this.lbl_compillers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_rmf = new System.Windows.Forms.Label();
            this.lbl_ass_files = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.list_wad = new System.Windows.Forms.ComboBox();
            this.list_spr = new System.Windows.Forms.ComboBox();
            this.list_pak = new System.Windows.Forms.ComboBox();
            this.list_mdl = new System.Windows.Forms.ComboBox();
            this.list_bsp = new System.Windows.Forms.ComboBox();
            this.list_map = new System.Windows.Forms.ComboBox();
            this.list_rmf = new System.Windows.Forms.ComboBox();
            this.dlist_lang = new System.Windows.Forms.ComboBox();
            this.btn_lang_info = new System.Windows.Forms.Button();
            this.brn_apply = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Enabled = false;
            this.pic_btn_min.Location = new System.Drawing.Point(253, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Enabled = false;
            this.pic_btn_max.Location = new System.Drawing.Point(277, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new System.Drawing.Point(301, 12);
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(45, 13);
            this.lbl_title.Text = "Settings";
            // 
            // btn_rescan
            // 
            this.btn_rescan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rescan.Location = new System.Drawing.Point(21, 309);
            this.btn_rescan.Name = "btn_rescan";
            this.btn_rescan.Size = new System.Drawing.Size(270, 23);
            this.btn_rescan.TabIndex = 7;
            this.btn_rescan.Text = "Rescan and Fix program list";
            this.btn_rescan.UseVisualStyleBackColor = true;
            this.btn_rescan.Click += new System.EventHandler(this.btn_rescan_Click);
            // 
            // lbl_def_lang
            // 
            this.lbl_def_lang.AutoSize = true;
            this.lbl_def_lang.Location = new System.Drawing.Point(18, 14);
            this.lbl_def_lang.Name = "lbl_def_lang";
            this.lbl_def_lang.Size = new System.Drawing.Size(91, 13);
            this.lbl_def_lang.TabIndex = 8;
            this.lbl_def_lang.Text = "Default language:";
            // 
            // panel_config
            // 
            this.panel_config.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.panel_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_config.Controls.Add(this.lbl_compillers);
            this.panel_config.Controls.Add(this.label7);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.label4);
            this.panel_config.Controls.Add(this.label3);
            this.panel_config.Controls.Add(this.label2);
            this.panel_config.Controls.Add(this.lbl_rmf);
            this.panel_config.Controls.Add(this.lbl_ass_files);
            this.panel_config.Controls.Add(this.comboBox1);
            this.panel_config.Controls.Add(this.list_wad);
            this.panel_config.Controls.Add(this.list_spr);
            this.panel_config.Controls.Add(this.list_pak);
            this.panel_config.Controls.Add(this.list_mdl);
            this.panel_config.Controls.Add(this.list_bsp);
            this.panel_config.Controls.Add(this.list_map);
            this.panel_config.Controls.Add(this.list_rmf);
            this.panel_config.Controls.Add(this.dlist_lang);
            this.panel_config.Controls.Add(this.lbl_def_lang);
            this.panel_config.Controls.Add(this.btn_lang_info);
            this.panel_config.Controls.Add(this.btn_rescan);
            this.panel_config.Location = new System.Drawing.Point(12, 34);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(307, 348);
            this.panel_config.TabIndex = 9;
            // 
            // lbl_compillers
            // 
            this.lbl_compillers.AutoSize = true;
            this.lbl_compillers.Location = new System.Drawing.Point(18, 287);
            this.lbl_compillers.Name = "lbl_compillers";
            this.lbl_compillers.Size = new System.Drawing.Size(111, 13);
            this.lbl_compillers.TabIndex = 10;
            this.lbl_compillers.Text = "Set default Compillers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "WAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SPR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PAK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MDL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "BSP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MAP:";
            // 
            // lbl_rmf
            // 
            this.lbl_rmf.AutoSize = true;
            this.lbl_rmf.Location = new System.Drawing.Point(18, 82);
            this.lbl_rmf.Name = "lbl_rmf";
            this.lbl_rmf.Size = new System.Drawing.Size(33, 13);
            this.lbl_rmf.TabIndex = 10;
            this.lbl_rmf.Text = "RMF:";
            // 
            // lbl_ass_files
            // 
            this.lbl_ass_files.AutoSize = true;
            this.lbl_ass_files.Location = new System.Drawing.Point(18, 63);
            this.lbl_ass_files.Name = "lbl_ass_files";
            this.lbl_ass_files.Size = new System.Drawing.Size(87, 13);
            this.lbl_ass_files.TabIndex = 10;
            this.lbl_ass_files.Text = "File associations:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default x32 (veryy old and broken)",
            "Zonner\'s x32 SSE",
            "Zonner\'s x32 SSE2",
            "Zonners\'s x64",
            "Vlucazan\'s x32 v31"});
            this.comboBox1.Location = new System.Drawing.Point(135, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // list_wad
            // 
            this.list_wad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_wad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_wad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_wad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_wad.FormattingEnabled = true;
            this.list_wad.Items.AddRange(new object[] {
            "None",
            "Wally"});
            this.list_wad.Location = new System.Drawing.Point(60, 255);
            this.list_wad.Name = "list_wad";
            this.list_wad.Size = new System.Drawing.Size(231, 21);
            this.list_wad.TabIndex = 9;
            // 
            // list_spr
            // 
            this.list_spr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_spr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_spr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_spr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_spr.FormattingEnabled = true;
            this.list_spr.Items.AddRange(new object[] {
            "None",
            "Sprite Explorer"});
            this.list_spr.Location = new System.Drawing.Point(60, 226);
            this.list_spr.Name = "list_spr";
            this.list_spr.Size = new System.Drawing.Size(231, 21);
            this.list_spr.TabIndex = 9;
            // 
            // list_pak
            // 
            this.list_pak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_pak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_pak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_pak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_pak.FormattingEnabled = true;
            this.list_pak.Items.AddRange(new object[] {
            "None",
            "Wally",
            "Pak Scape",
            "Pak Explorer"});
            this.list_pak.Location = new System.Drawing.Point(60, 197);
            this.list_pak.Name = "list_pak";
            this.list_pak.Size = new System.Drawing.Size(231, 21);
            this.list_pak.TabIndex = 9;
            // 
            // list_mdl
            // 
            this.list_mdl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_mdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_mdl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_mdl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_mdl.FormattingEnabled = true;
            this.list_mdl.Items.AddRange(new object[] {
            "None",
            "Jed\'s MDL Viewer",
            "Crafty (Object Viewer)"});
            this.list_mdl.Location = new System.Drawing.Point(60, 168);
            this.list_mdl.Name = "list_mdl";
            this.list_mdl.Size = new System.Drawing.Size(231, 21);
            this.list_mdl.TabIndex = 9;
            // 
            // list_bsp
            // 
            this.list_bsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_bsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_bsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_bsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_bsp.FormattingEnabled = true;
            this.list_bsp.Items.AddRange(new object[] {
            "None",
            "BSP Viewer",
            "Crafty (Object Viewer)"});
            this.list_bsp.Location = new System.Drawing.Point(60, 139);
            this.list_bsp.Name = "list_bsp";
            this.list_bsp.Size = new System.Drawing.Size(231, 21);
            this.list_bsp.TabIndex = 9;
            // 
            // list_map
            // 
            this.list_map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_map.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_map.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_map.FormattingEnabled = true;
            this.list_map.Items.AddRange(new object[] {
            "None",
            "MAP Viewer",
            "Crafty (Object Viewer)"});
            this.list_map.Location = new System.Drawing.Point(60, 108);
            this.list_map.Name = "list_map";
            this.list_map.Size = new System.Drawing.Size(231, 21);
            this.list_map.TabIndex = 9;
            // 
            // list_rmf
            // 
            this.list_rmf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.list_rmf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_rmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_rmf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.list_rmf.FormattingEnabled = true;
            this.list_rmf.Items.AddRange(new object[] {
            "None",
            "Original Hamer 3.4\\3.5",
            "Hammer 3.5 Neo",
            "Hammer 3.5 Neon",
            "Hammer 3.5 CSM",
            "WorldCraft (Hammer 3.3)",
            "Sledge",
            "Quark"});
            this.list_rmf.Location = new System.Drawing.Point(60, 79);
            this.list_rmf.Name = "list_rmf";
            this.list_rmf.Size = new System.Drawing.Size(231, 21);
            this.list_rmf.TabIndex = 9;
            // 
            // dlist_lang
            // 
            this.dlist_lang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.dlist_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlist_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlist_lang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.dlist_lang.FormattingEnabled = true;
            this.dlist_lang.Items.AddRange(new object[] {
            "English (Default)"});
            this.dlist_lang.Location = new System.Drawing.Point(21, 30);
            this.dlist_lang.Name = "dlist_lang";
            this.dlist_lang.Size = new System.Drawing.Size(192, 21);
            this.dlist_lang.TabIndex = 9;
            // 
            // btn_lang_info
            // 
            this.btn_lang_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lang_info.Location = new System.Drawing.Point(219, 28);
            this.btn_lang_info.Name = "btn_lang_info";
            this.btn_lang_info.Size = new System.Drawing.Size(72, 23);
            this.btn_lang_info.TabIndex = 7;
            this.btn_lang_info.Text = "Info";
            this.btn_lang_info.UseVisualStyleBackColor = true;
            // 
            // brn_apply
            // 
            this.brn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brn_apply.Location = new System.Drawing.Point(244, 388);
            this.brn_apply.Name = "brn_apply";
            this.brn_apply.Size = new System.Drawing.Size(75, 23);
            this.brn_apply.TabIndex = 10;
            this.brn_apply.Text = "Apply";
            this.brn_apply.UseVisualStyleBackColor = true;
            this.brn_apply.Click += new System.EventHandler(this.brn_apply_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(12, 388);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 423);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.brn_apply);
            this.Controls.Add(this.panel_config);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 423);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(331, 423);
            this.Name = "frm_settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_settings_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.panel_config, 0);
            this.Controls.SetChildIndex(this.brn_apply, 0);
            this.Controls.SetChildIndex(this.btn_update, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rescan;
        private System.Windows.Forms.Label lbl_def_lang;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.ComboBox dlist_lang;
        private System.Windows.Forms.Label lbl_ass_files;
     
        private System.Windows.Forms.ComboBox list_wad;
        private System.Windows.Forms.ComboBox list_spr;
        private System.Windows.Forms.ComboBox list_pak;
        private System.Windows.Forms.ComboBox list_mdl;
        private System.Windows.Forms.ComboBox list_bsp;
        private System.Windows.Forms.ComboBox list_map;
        private System.Windows.Forms.ComboBox list_rmf;
       
        private System.Windows.Forms.Button brn_apply;
        private System.Windows.Forms.ComboBox comboBox1;
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_rmf;
        private System.Windows.Forms.Label lbl_compillers;
        private System.Windows.Forms.Button btn_lang_info;
        private System.Windows.Forms.Button btn_update;
    
    }
}