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
using System.Globalization;
using System.IO;
using System.Linq;
using gSDK_Launcher.UI;
using gSDK_vgui;
using System.Windows.Forms;
using System;
using gSDK_Launcher.Core;

namespace gSDK_Launcher {
    public partial class FrmMain : FrmTemplate {

        public FrmMain() {
            InitializeComponent();
            if (Program.Refresh) {
               // MessageBox.Show("true");
                frm_scanning frmscanning = new frm_scanning();
                frmscanning.ShowDialog();
            }
        }
        private void btn_about_Click( object sender, EventArgs e ) {
            new FrmAbout().ShowDialog();
        }
        private void btn_settings_Click( object sender, EventArgs e ) {
            new FrmSettings().ShowDialog();
            ReloadSoftware();
            Globals.Translator.Translate( Controls.OfType<Control>(), Name );
        }
        private void btn_exit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }
        private void frm_main_Load( object sender, EventArgs e ) {
            #region Load cfg

            var d = Path.GetDirectoryName(AssemblyInfoHelper.CurrentAssembly.Location);
            var configpath = Path.Combine( d, "configs", "list.xml" );
            try {
                Globals.Config = Config.Load( configpath );
                if ( String.IsNullOrEmpty( Globals.Config.Lang ) ) {
                    Globals.Config.Lang = CultureInfo.CurrentUICulture.Name;
                }
                var trans = Path.Combine(d,"langs", Globals.Config.Lang + ".xml" );
                if ( File.Exists( trans ) )
                    Globals.Translator = AbyrvalgTranslator.Load( trans );
                else
                    Globals.Translator = new AbyrvalgTranslator {
                        Author = "stam",
                        Culture = "en-US",
                        Version = "1.5.0.0"
                    };
            }
            catch ( Exception ) {
                if ( MessageBox.Show(
                    @"Cant't load config file. Create new?",
                    @"Error!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error ) != DialogResult.OK )
                    return;
                try {
                    File.WriteAllText( configpath, Properties.Resources.dftcfg );
                }
                catch ( Exception ) {
                    MessageBox.Show(
                        @"Error",
                        @"Unable to update config. Contact to support.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error );
                    Application.Exit();
                    return;
                }
            }
            #endregion
            SoftwareDetector.CheckAllInConfig( Globals.Config );
            Globals.Translator.Translate( Controls.OfType<Control>(), Name );
            ReloadSoftware();
        }

        private void ReloadSoftware() {
            listv_programs.BeginUpdate();
            listv_programs.Items.Clear();
            listv_programs.Groups.Clear();
            IDisposable a = listv_programs.LargeImageList;
            if ( a != null ) a.Dispose();
            a = listv_programs.SmallImageList;
            if ( a != null ) a.Dispose();
            listv_programs.LargeImageList = new ImageList {
                ImageSize = new Size( 16, 16 ),
                ColorDepth = ColorDepth.Depth32Bit
            };
            listv_programs.SmallImageList = listv_programs.LargeImageList;
            var eric = SystemIcons.Error;
            foreach ( var category in  Globals.Config.Apps.Concat(new[] {Globals.Config.Custom }) ) {
                    var grp = new ListViewGroup( category.Name, category.Name );
                    listv_programs.Groups.Add( grp );
                    foreach ( var app in category.Apps.Where( x => x.Installed ) ) {
                        var ip = app.Path.ToString();
                        try {
                            var ico = File.Exists( ip )
                                      ? Icon.ExtractAssociatedIcon( ip )
                                      : ( File.Exists( ip = AssemblyInfoHelper.GetPath( app.IconPath.ToString() ) )
                                              ? Icon.ExtractAssociatedIcon( ip )
                                              : eric );
                            listv_programs.LargeImageList.Images.Add( ip, ico );
                        }
                        catch {
                            listv_programs.LargeImageList.Images.Add( ip, eric );
                        }
                        listv_programs.Items.Add( new ListViewItem( app.Name, ip, grp ) {
                            Tag = app,
                        } );
                    }
                //}
            }
            var gr = new ListViewGroup( Globals.Config.Support.Name, Globals.Config.Support.Name );
            listv_programs.Groups.Add( gr );
            foreach ( var app in Globals.Config.Support.Apps ) {
                var ip = app.Path.ToString();
                listv_programs.LargeImageList.Images.Add( ip, Properties.Resources.ie );
                var item = new ListViewItem( app.Name, ip, gr ) {
                    Tag = app
                };
                listv_programs.Items.Add( item );
            }
            listv_programs.EndUpdate();
        }
        private void listv_programs_DoubleClick( object sender, EventArgs e ) {
            var v = listv_programs.SelectedItems;
            if ( v.Count == 0 ) return;
            var it = v[ 0 ];
            if ( it == null ) return;
            var info = it.Tag as App;
            if ( info == null ) return;
            try {
                Process.Start( info.Path.ToString(), info.Params );
            }
            catch ( Exception ) {
                MessageBox.Show(
                    string.Format(
                        "Failed to run {0}({1})",
                        info.Name, info.Path
                    ),
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btn_additem_Click( object sender, EventArgs e ) {
            new FrmCustomSection().ShowDialog();
            ReloadSoftware();
        }
    }
}