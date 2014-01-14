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
            new FrmSettings().ShowDialog();
            this.ReloadSoftware();

        }
        private void btn_exit_Click( object sender, EventArgs e ) {
            Application.Exit();
        }
        private void frm_main_Load( object sender, EventArgs e ) {

            #region Load cfg
            var configpath = Path.Combine(
                Path.GetDirectoryName( AssemblyInfoHelper.CurrentAssembly.Location ),
                "configs",
                "list.xml" );
            try {
                Globals.Config = Config.Load( configpath );
                if ( String.IsNullOrEmpty( Globals.Config.LANG ) ) {
                    Globals.Config.LANG = CultureInfo.CurrentUICulture.Name;
                }
                var trans = Path.Combine(
                        Path.GetDirectoryName( AssemblyInfoHelper.CurrentAssembly.Location ),
                        "langs",
                        Globals.Config.LANG + ".xml" );
                if ( File.Exists( trans ) )
                    Globals.Translator = AbyrvalgTranslator.Load( trans );
                else
                    Globals.Translator = new AbyrvalgTranslator {
                        Author = "stam",
                        Culture = "en-US",
                        Version = "1.4.8.8"
                    };
            }
            catch ( Exception ) {
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
            SoftwareDetector.CheckAllInConfig( Globals.Config );
            Globals.Translator.Translate( this.Controls.OfType<Control>(), this.Name );
            ReloadSoftware();
        }

        private void ReloadSoftware() {
            this.listv_programs.BeginUpdate();
            this.listv_programs.Items.Clear();
            this.listv_programs.Groups.Clear();
            IDisposable a = this.listv_programs.LargeImageList;
            if ( a != null ) a.Dispose();
            a = this.listv_programs.SmallImageList;
            if ( a != null ) a.Dispose();
            this.listv_programs.LargeImageList = new ImageList {
                ImageSize = new Size( 16, 16 ),
                ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
            };
            this.listv_programs.SmallImageList = this.listv_programs.LargeImageList;
            var eric = SystemIcons.Error;

            foreach ( var category in Globals.Config.Apps ) {
                var grp = new ListViewGroup( category.Name, category.Name );
                this.listv_programs.Groups.Add( grp );
                foreach ( var app in category.Apps.Where( x => x.Installed ) ) {
                    var ip = AssemblyInfoHelper.GetPath( app.Path );
                    try {
                        var ico = File.Exists( ip ) ?
                            Icon.ExtractAssociatedIcon( ip ) :
                            File.Exists( ip = AssemblyInfoHelper.GetPath( app.IconPath ) ) ? Icon.ExtractAssociatedIcon( ip ) : eric;
                        this.listv_programs.LargeImageList.Images.Add( ip, ico );
                    }
                    catch {
                        this.listv_programs.LargeImageList.Images.Add( ip, eric );
                    }
                    var item = new ListViewItem( app.Name, ip, grp ) {
                        Tag = app,
                    };
                    //item.ImageList = this.listv_programs.LargeImageList;
                    this.listv_programs.Items.Add( item );
                }
            }
            var gr = new ListViewGroup( Globals.Config.Support.Name, Globals.Config.Support.Name );
            this.listv_programs.Groups.Add( gr );
            foreach ( var app in Globals.Config.Support.Apps ) {
                var ip = AssemblyInfoHelper.GetPath( app.Path );
                try {
                    // this.listv_programs.LargeImageList.Images.Add(ip, System.Drawing.SystemIcons.WinLogo);
                    this.listv_programs.LargeImageList.Images.Add( ip, Properties.Resources.ie );
                }
                catch {
                    this.listv_programs.LargeImageList.Images.Add( ip, eric );
                }
                var item = new ListViewItem( app.Name, ip, gr ) {

                    Tag = app,
                };

                //item.ImageList = this.listv_programs.LargeImageList;
                this.listv_programs.Items.Add( item );
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

                Process.Start( info.Path.StartsWith( "http" ) ? info.Path : AssemblyInfoHelper.GetPath( info.Path ) );
            }
            catch ( Exception ) {
                MessageBox.Show(
                    string.Format(
                        "Failed to run {0}({1})",
                        info.Name, AssemblyInfoHelper.GetPath( info.Path )
                    ),
                    "ЕГГОГ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
