namespace gSDK_Launcher {
    partial class frm_main {
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Location = new System.Drawing.Point(281, 12);
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Location = new System.Drawing.Point(305, 12);
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new System.Drawing.Point(329, 12);
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new System.Drawing.Size(136, 13);
            this.lbl_title.Text = "GoldSource SDK Launcher";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(336, 180);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(272, 229);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 25);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Close";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.btn_about.Location = new System.Drawing.Point(12, 229);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 25);
            this.btn_about.TabIndex = 8;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 266);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(360, 266);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.btn_exit, 0);
            this.Controls.SetChildIndex(this.btn_about, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_about;

       


    }
}