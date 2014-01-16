using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace gSDK_Launcher.UI {
    partial class FrmCustomSection {
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
            this.panel_back = new Panel();
            this.label1 = new Label();
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.lbl_commandline = new Label();
            this.lbl_custom_list = new Label();
            this.txt_arguments = new TextBox();
            this.list_custom_items = new ListView();
            this.btn_saveit = new Button();
            this.btn_add_item = new Button();
            this.btn_delete_selected = new Button();
            this.ofdExe = new OpenFileDialog();
            ((ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Enabled = false;
            this.pic_btn_min.Location = new Point(274, 12);
            this.pic_btn_min.Visible = false;
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Enabled = false;
            this.pic_btn_max.Location = new Point(298, 12);
            this.pic_btn_max.Visible = false;
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new Point(322, 12);
            // 
            // lbl_title
            // 
            this.lbl_title.Size = new Size(54, 13);
            this.lbl_title.Text = "Edit menu";
            // 
            // panel_back
            // 
            this.panel_back.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.panel_back.BackColor = Color.FromArgb(62, 70, 55);
            this.panel_back.Controls.Add(this.label1);
            this.panel_back.Controls.Add(this.button1);
            this.panel_back.Controls.Add(this.textBox1);
            this.panel_back.Controls.Add(this.lbl_commandline);
            this.panel_back.Controls.Add(this.lbl_custom_list);
            this.panel_back.Controls.Add(this.txt_arguments);
            this.panel_back.Controls.Add(this.list_custom_items);
            this.panel_back.Location = new Point(12, 34);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new Size(328, 293);
            this.panel_back.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(3, 213);
            this.label1.Name = "label1";
            this.label1.Size = new Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Program";
            // 
            // button1
            // 
            this.button1.BackColor = Color.FromArgb(76, 88, 68);
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(286, 229);
            this.button1.Name = "button1";
            this.button1.Size = new Size(39, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = Color.FromArgb(62, 70, 55);
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.Location = new Point(6, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(274, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_commandline
            // 
            this.lbl_commandline.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.lbl_commandline.AutoSize = true;
            this.lbl_commandline.Location = new Point(3, 254);
            this.lbl_commandline.Name = "lbl_commandline";
            this.lbl_commandline.Size = new Size(119, 13);
            this.lbl_commandline.TabIndex = 2;
            this.lbl_commandline.Text = "Commanline arguments:";
            // 
            // lbl_custom_list
            // 
            this.lbl_custom_list.AutoSize = true;
            this.lbl_custom_list.Location = new Point(3, 9);
            this.lbl_custom_list.Name = "lbl_custom_list";
            this.lbl_custom_list.Size = new Size(72, 13);
            this.lbl_custom_list.TabIndex = 2;
            this.lbl_custom_list.Text = "Custom items:";
            // 
            // txt_arguments
            // 
            this.txt_arguments.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.txt_arguments.BackColor = Color.FromArgb(62, 70, 55);
            this.txt_arguments.BorderStyle = BorderStyle.FixedSingle;
            this.txt_arguments.Location = new Point(6, 270);
            this.txt_arguments.Name = "txt_arguments";
            this.txt_arguments.Size = new Size(319, 20);
            this.txt_arguments.TabIndex = 1;
            // 
            // list_custom_items
            // 
            this.list_custom_items.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.list_custom_items.BackColor = Color.FromArgb(62, 70, 55);
            this.list_custom_items.BorderStyle = BorderStyle.FixedSingle;
            this.list_custom_items.ForeColor = Color.FromArgb(136, 145, 128);
            this.list_custom_items.Location = new Point(3, 25);
            this.list_custom_items.Name = "list_custom_items";
            this.list_custom_items.Size = new Size(322, 185);
            this.list_custom_items.TabIndex = 0;
            this.list_custom_items.UseCompatibleStateImageBehavior = false;
            // 
            // btn_saveit
            // 
            this.btn_saveit.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.btn_saveit.FlatStyle = FlatStyle.Popup;
            this.btn_saveit.Location = new Point(265, 333);
            this.btn_saveit.Name = "btn_saveit";
            this.btn_saveit.Size = new Size(75, 23);
            this.btn_saveit.TabIndex = 8;
            this.btn_saveit.Text = "Save";
            this.btn_saveit.UseVisualStyleBackColor = true;
            this.btn_saveit.Click += new System.EventHandler(this.btn_saveit_Click);
            // 
            // btn_add_item
            // 
            this.btn_add_item.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.btn_add_item.FlatStyle = FlatStyle.Popup;
            this.btn_add_item.Location = new Point(12, 333);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new Size(75, 23);
            this.btn_add_item.TabIndex = 8;
            this.btn_add_item.Text = "Add";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // btn_delete_selected
            // 
            this.btn_delete_selected.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.btn_delete_selected.FlatStyle = FlatStyle.Popup;
            this.btn_delete_selected.Location = new Point(93, 333);
            this.btn_delete_selected.Name = "btn_delete_selected";
            this.btn_delete_selected.Size = new Size(75, 23);
            this.btn_delete_selected.TabIndex = 8;
            this.btn_delete_selected.Text = "Delete";
            this.btn_delete_selected.UseVisualStyleBackColor = true;
            this.btn_delete_selected.Click += new System.EventHandler(this.btn_delete_selected_Click);
            // 
            // ofdExe
            // 
            this.ofdExe.RestoreDirectory = true;
            this.ofdExe.Title = "Select program";
            // 
            // FrmCustomSection
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.ClientSize = new Size(352, 368);
            this.Controls.Add(this.btn_delete_selected);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.btn_saveit);
            this.Controls.Add(this.panel_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(352, 368);
            this.Name = "FrmCustomSection";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit menu";
            this.Load += new System.EventHandler(this.FrmCustomSection_Load);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.panel_back, 0);
            this.Controls.SetChildIndex(this.btn_saveit, 0);
            this.Controls.SetChildIndex(this.btn_add_item, 0);
            this.Controls.SetChildIndex(this.btn_delete_selected, 0);
            ((ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_back.ResumeLayout(false);
            this.panel_back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_back;
        private Button btn_saveit;
        private ListView list_custom_items;
        private Button btn_delete_selected;
        private Button btn_add_item;
        private Label lbl_commandline;
        private Label lbl_custom_list;
        private TextBox txt_arguments;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private OpenFileDialog ofdExe;
    }
}