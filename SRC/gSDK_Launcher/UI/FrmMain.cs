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

using System.Diagnostics;
using System.Drawing;
using System.IO;
using gSDK_vgui;
using System.Windows.Forms;
using System;
namespace gSDK_Launcher {
    public partial class FrmMain : FrmTemplate {

        public FrmMain() {
            InitializeComponent();
        }
        private void btn_about_Click( object sender, EventArgs e ) {
            new frm_about().ShowDialog();
        }
        private void button1_Click( object sender, EventArgs e ) {
            new frm_scanning().ShowDialog();
        }
        private void btn_settings_Click( object sender, EventArgs e ) {
            new frm_settings().ShowDialog();
        }
        private void btn_exit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }
        private void frm_main_Load( object sender, EventArgs e ) {
            #region Load cfg
                var configpath = Path.Combine( "configs", "list.xml" );
                try {
                    Globals.Config = Config.Load( configpath );
                }
                catch (Exception) {
                    if ( MessageBox.Show(
                        "Cant't load config file. Create new?",
                        "ЕГГОГ!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error ) != DialogResult.OK )
                        return;
                    try {
                        File.WriteAllText( configpath, Properties.Resources.dftcfg );
                    }
                    catch ( Exception ex2 ) {
                        MessageBox.Show(
                            "ЕГГОГ",
                            "Unable to update config. Contact to ya odmin.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error );
                        Application.Exit();
                        return;
                    }
                }
            #endregion
            
            this.listv_programs.BeginUpdate();
            this.listv_programs.Items.Clear();
            this.listv_programs.Groups.Clear();
            IDisposable a = this.listv_programs.LargeImageList;
            if (a!=null) a.Dispose();
            a = this.listv_programs.SmallImageList;
            if ( a != null ) a.Dispose();
            this.listv_programs.LargeImageList = new ImageList {
                ImageSize = new Size( 16, 16 )
            };
            this.listv_programs.SmallImageList = this.listv_programs.LargeImageList;
            Icon eric = SystemIcons.Error;
            
            foreach ( var category in Globals.Config.Apps ) {
                var grp = new ListViewGroup( category.Name, category.Name );
                this.listv_programs.Groups.Add( grp );
                foreach ( var app in category.Apps ) {
                    try {
                        var ico = File.Exists( app.IconPath )?
                            Icon.ExtractAssociatedIcon( app.IconPath ):
                            eric;
                        this.listv_programs.LargeImageList.Images.Add( app.IconPath, ico );
                    }
                    catch {
                        this.listv_programs.LargeImageList.Images.Add( app.IconPath, eric);
                    }
                    var item = new ListViewItem( app.Name, app.IconPath, grp ) {
                            Tag = app,
                        };
                    //item.ImageList = this.listv_programs.LargeImageList;
                    this.listv_programs.Items.Add( item );
                }
            }
            this.listv_programs.EndUpdate();
        }

        private void listv_programs_DoubleClick( object sender, EventArgs e ) {
            var v = this.listv_programs.SelectedItems;
            if ( v.Count == 0 ) return;
            var it = v[ 0 ];
            if ( it != null && ( it.Tag == null || !( it.Tag is App ) ) ) return;
            var info = it.Tag as App;
            try {
                Process.Start( AssemblyInfoHelper.GetPath(
                    info.Path
                ) );
            }
            catch (Exception) {
                MessageBox.Show( "Failed to run " + info.Name, "ЕГГОГ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
