namespace gSDK_vgui {
    partial class frm_main {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line_v1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.line_h1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pic_btn_max = new System.Windows.Forms.PictureBox();
            this.pic_btn_exit = new System.Windows.Forms.PictureBox();
            this.pic_btn_min = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2,
            this.line_v1,
            this.line_h1});
            this.shapeContainer1.Size = new System.Drawing.Size(197, 173);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lineShape1.X1 = 198;
            this.lineShape1.X2 = 0;
            this.lineShape1.Y1 = 197;
            this.lineShape1.Y2 = 197;
            // 
            // lineShape2
            // 
            this.lineShape2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(34)))));
            this.lineShape2.X1 = 197;
            this.lineShape2.X2 = 197;
            this.lineShape2.Y1 = 198;
            this.lineShape2.Y2 = 0;
            // 
            // line_v1
            // 
            this.line_v1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.line_v1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.line_v1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.line_v1.Enabled = false;
            this.line_v1.Name = "line_v1";
            this.line_v1.X1 = 0;
            this.line_v1.X2 = 0;
            this.line_v1.Y1 = 198;
            this.line_v1.Y2 = 0;
            // 
            // line_h1
            // 
            this.line_h1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.line_h1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line_h1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.line_h1.Enabled = false;
            this.line_h1.Name = "line_h1";
            this.line_h1.X1 = 0;
            this.line_h1.X2 = 198;
            this.line_h1.Y1 = 0;
            this.line_h1.Y2 = 0;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_btn_max.Image = global::gSDK_vgui.Properties.Resources.max_button_na;
            this.pic_btn_max.Location = new System.Drawing.Point(142, 12);
            this.pic_btn_max.Name = "pic_btn_max";
            this.pic_btn_max.Size = new System.Drawing.Size(18, 18);
            this.pic_btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_btn_max.TabIndex = 4;
            this.pic_btn_max.TabStop = false;
            this.pic_btn_max.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_btn_max_MouseClick);
            this.pic_btn_max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_btn_max_MouseDown);
            this.pic_btn_max.MouseEnter += new System.EventHandler(this.pic_max_btn_MouseEnter);
            this.pic_btn_max.MouseLeave += new System.EventHandler(this.pic_btn_max_MouseLeave);
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_btn_exit.Image = global::gSDK_vgui.Properties.Resources.exit_button_na;
            this.pic_btn_exit.Location = new System.Drawing.Point(166, 12);
            this.pic_btn_exit.Name = "pic_btn_exit";
            this.pic_btn_exit.Size = new System.Drawing.Size(18, 18);
            this.pic_btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_btn_exit.TabIndex = 3;
            this.pic_btn_exit.TabStop = false;
            this.pic_btn_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_btn_exit_MouseClick);
            this.pic_btn_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_btn_exit_MouseDown);
            this.pic_btn_exit.MouseEnter += new System.EventHandler(this.pic_btn_exit_MouseEnter);
            this.pic_btn_exit.MouseLeave += new System.EventHandler(this.pic_btn_exit_MouseLeave);
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_btn_min.Image = global::gSDK_vgui.Properties.Resources.min_button_na;
            this.pic_btn_min.Location = new System.Drawing.Point(118, 12);
            this.pic_btn_min.Name = "pic_btn_min";
            this.pic_btn_min.Size = new System.Drawing.Size(18, 18);
            this.pic_btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_btn_min.TabIndex = 2;
            this.pic_btn_min.TabStop = false;
            this.pic_btn_min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_btn_min_MouseClick);
            this.pic_btn_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_btn_min_MouseDown);
            this.pic_btn_min.MouseEnter += new System.EventHandler(this.pic_btn_min_MouseEnter);
            this.pic_btn_min.MouseLeave += new System.EventHandler(this.pic_btn_min_MouseLeave);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(197, 173);
            this.Controls.Add(this.pic_btn_max);
            this.Controls.Add(this.pic_btn_exit);
            this.Controls.Add(this.pic_btn_min);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gSDK Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line_h1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line_v1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pic_btn_min;
        private System.Windows.Forms.PictureBox pic_btn_exit;
        private System.Windows.Forms.PictureBox pic_btn_max;





    }
}

