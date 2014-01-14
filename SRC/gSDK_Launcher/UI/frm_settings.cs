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
using System.IO;
using System.Linq;
using System.Windows.Forms;
using gSDK_Launcher.Core;
using gSDK_vgui;

namespace gSDK_Launcher.UI {
    public partial class FrmSettings : FrmTemplate {
        public FrmSettings() {
            this.InitializeComponent();
        }
        private void frm_settings_Load( object sender, EventArgs e ) {
            this.dlist_lang.SelectedIndex = 0;
            Globals.Translator.Translate( this.Controls.OfType<Control>(), this.Name );
            this.dlist_lang.BeginUpdate();
            this.dlist_lang.Items.Clear();
            this.dlist_lang.Items.AddRange(
                Directory.GetFiles(
                    Path.Combine(
                        Path.GetDirectoryName( AssemblyInfoHelper.CurrentAssembly.Location ),
                        "langs"
                    )
                )
                .Select( AbyrvalgTranslator.Load )
                .ToArray()
            );
            this.dlist_lang.Items.Add(
                new AbyrvalgTranslator {
                    Author = "stam",
                    Culture = "en-US",
                    Version = "1.4.8.8"
                } );
            this.dlist_lang.SelectedItem =
                this.dlist_lang.Items.OfType<AbyrvalgTranslator>().First( a => a.Culture == Globals.Config.LANG );
            this.dlist_lang.EndUpdate();
            LoadExt( "rmf", this.list_rmf );
            LoadExt( "map", this.list_map );
            LoadExt( "bsp", this.list_bsp );
            LoadExt( "mdl", this.list_mdl );
            LoadExt( "pak", this.list_pak );
            LoadExt( "spr", this.list_spr );
            LoadExt( "wad", this.list_wad );
        }

        private static void LoadExt( string a, ComboBox b ) {
            b.BeginUpdate();
            try {
                b.Items.Clear();
                var exts = GetAppForExt( a );
                b.Items.AddRange( exts );
                var current = Ext.GetCurrentProgID( a );
                b.Items.Add( "None" );
                if ( current != null ) {
                    if ( !exts.Any( x => x.Name.Replace( " ", "." ) == current ) ) {
                        b.Items.Add( "Other" );
                        b.SelectedIndex = b.Items.Count - 1;
                    }
                    else
                        b.SelectedItem = b.Items.OfType<App>().First( x => x.Name.Replace( " ", "." ) == current );
                }
                else {
                    b.SelectedIndex = b.Items.Count - 1;
                }
            }
            catch ( Exception ex ) {
                Console.WriteLine( ex.Message );
            }
            b.EndUpdate();
        }
        //я в ыцакмпыииовырдолиюрглжмрварг
        private static App[] GetAppForExt( string x ) {
            return
                Globals.Config.Apps.SelectMany( a => a.Apps )
                    .Where( a => a.Installed )
                    .Where( a => a.Extensions.Any( b => b == x ) )
                    .ToArray();
        }
        private void btn_rescan_Click( object sender, EventArgs e ) {
            var configpath = Path.Combine( "configs", "list.xml" );
            try {
                SoftwareDetector.CheckAllInConfig( Globals.Config );
                Globals.Config.Save( configpath );
            }
            catch { }
        }
        private void brn_apply_Click( object sender, EventArgs e ) {
            try {
                var c = ( this.dlist_lang.SelectedItem as AbyrvalgTranslator );
                if ( c != null && Globals.Config.LANG != c.Culture ) {
                    Globals.Config.LANG = c.Culture;
                    Globals.Config.Save(
                        Path.Combine(
                            Path.GetDirectoryName( AssemblyInfoHelper.CurrentAssembly.Location ),
                            "configs",
                            "list.xml"
                        )
                    );
                }
                foreach ( var result in this.panel_config.Controls.OfType<ComboBox>() )
                    this.sv( result );
                Action<string, ComboBox> sv = ( a, b ) => {
                    var it = b.SelectedItem;
                    var app = it as App;
                    var progid = "";
                    if ( it is string ) {
                        if ( (string) it == "Other" ) return;
                    }
                    else if ( app != null ) progid = ( app ).Name.Replace( " ", "." );
                    new Ext {
                        Extension = a,
                        ProgID = progid
                    }.Save();
                };
                sv( "rmf", this.list_rmf );
                sv( "map", this.list_map );
                sv( "bsp", this.list_bsp );
                sv( "mdl", this.list_mdl );
                sv( "pak", this.list_pak );
                sv( "spr", this.list_spr );
                sv( "wad", this.list_wad );
            }
            catch (UnauthorizedAccessException) {
                MessageBox.Show(
                    @"Can't update associations: access denied",
                    @"ЕГГОГ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
            catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
            this.Close();
        }

        private void sv( ComboBox l ) {
            var app = l.SelectedItem as App;
            if ( app == null ) return;
            new ProgID {
                Command = app.Path,
                IconPath = app.Path,
                Name = app.Name.Replace( " ", "." )
            }.Save();
        }

        private void btn_update_Click( object sender, EventArgs e ) {
            if (
                MessageBox.Show(
                    @"Updater will penmanently close launcher. Save settings before use it!" + Environment.NewLine
                    + @"Continue?",
                    @"Warning!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1 ) == DialogResult.Yes ) {
                MessageBox.Show( "closing launcher via App..Exit();\r\nStarting updater.exe" );
            }
        }
    }
}
