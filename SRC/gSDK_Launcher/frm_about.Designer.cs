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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_about = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Location = new System.Drawing.Point(546, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Location = new System.Drawing.Point(570, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Enabled = false;
            this.pic_btn_exit.Location = new System.Drawing.Point(594, 12);
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
            this.btn_close.Location = new System.Drawing.Point(12, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "OK";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gSDK_Launcher.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_about
            // 
            this.panel_about.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.panel_about.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_about.Controls.Add(this.label1);
            this.panel_about.Controls.Add(this.pictureBox1);
            this.panel_about.Location = new System.Drawing.Point(12, 34);
            this.panel_about.Name = "panel_about";
            this.panel_about.Size = new System.Drawing.Size(600, 341);
            this.panel_about.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "<program_name>";
            // 
            // frm_about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.panel_about);
            this.Controls.Add(this.btn_close);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_about";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frm_about_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.panel_about, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_about.ResumeLayout(false);
            this.panel_about.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel_about;
        private System.Windows.Forms.Label label1;
    }
}