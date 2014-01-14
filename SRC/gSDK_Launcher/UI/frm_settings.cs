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

using System.IO;
using System.Linq;
using System.Windows.Forms;
using gSDK_Launcher.Core;
using gSDK_vgui; 
using System;


namespace gSDK_Launcher {
    public partial class frm_settings : FrmTemplate {
        public frm_settings() {
            InitializeComponent();
        }
        private void frm_settings_Load(object sender, EventArgs e) {
            dlist_lang.SelectedIndex = 0;
            Func<string, App[]> getAppsForExt =
                (x)=>Globals.Config.Apps.SelectMany( a=>a.Apps ).Where( a=>a.Installed ).Where( a=>a.Extensions.Any( b=>b==x ) ).ToArray();
            Action<string, ComboBox> sv = ( a, b ) => {
                b.BeginUpdate();
                b.Items.Clear();
                b.Items.AddRange( getAppsForExt( a ) );
                b.EndUpdate();
            };
            sv( ".rmf", list_rmf );
            sv( ".bsp", list_bsp );
            sv( ".mdl", list_bsp );
            sv( ".pak", list_pak );
            sv( ".spr", list_mdl );
            sv( ".wad", list_wad );
        }
        private void btn_rescan_Click(object sender, EventArgs e) {
            var configpath = Path.Combine( "configs", "list.xml" );
            try {
                SoftwareDetector.CheckAllInConfig( Globals.Config );
                Globals.Config.Save( configpath );
            }
            catch {}
        }
        private void brn_apply_Click(object sender, EventArgs e) {
            foreach (var result in this.panel_config.Controls.OfType<ComboBox>())
                this.sv( result );
            Action<string, ComboBox> sv = ( a, b ) => {
                new Ext {
                    Extension = a,
                    ProgID = ( b.SelectedItem as App ).Name.Replace( " ", "." )
                }.Save();
            };
            sv( ".rmf", list_rmf );
            sv( ".bsp", list_bsp );
            sv( ".mdl", list_bsp );
            sv( ".pak", list_pak );
            sv( ".spr", list_mdl );
            sv( ".wad", list_wad );
            this.Close();
        }

        private void sv( ComboBox l ) {
            var app = l.SelectedItem as App;
            if ( app == null ) return;
            new ProgID() {
                Command = app.Path,
                IconPath = app.IconPath,
                Name = app.Name.Replace( " ","." )
            }.Save();
        }
    }
}
