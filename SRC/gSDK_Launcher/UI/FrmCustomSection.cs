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
using gSDK_vgui;
using System.Linq;
using System.Windows.Forms;
using gSDK_Launcher.Core;

namespace gSDK_Launcher.UI {
    public partial class FrmCustomSection : FrmTemplate {
        public FrmCustomSection() {
            InitializeComponent();
        }

        private void FrmCustomSection_Load( object sender, EventArgs e ) {
            Globals.Translator.Translate( Controls.OfType<Control>(), Name );
            list_custom_items.Items.AddRange( Globals.Config.Custom.Apps.Select( a=>new ListViewItem(Name=a.Name){Tag = a} ).ToArray() );
        }

        private void button1_Click( object sender, EventArgs e ) {
            if ( ofdExe.ShowDialog() == DialogResult.OK )
                textBox1.Text = ofdExe.FileName;
        }

        private void btn_delete_selected_Click( object sender, EventArgs e ) {
            var v = list_custom_items.SelectedIndices;
            if ( v.Count == 0 ) return;
            list_custom_items.BeginUpdate();
            foreach ( var v2 in v.OfType<int>().Reverse().ToArray() )
                list_custom_items.Items.RemoveAt( v2 );
            list_custom_items.EndUpdate();
        }

        private void btn_add_item_Click( object sender, EventArgs e ) {
            var app = new App {
                    Path = new RPath {
                        Path = textBox1.Text,
                        Type = PathType.Absolute
                    },
                    Installed = true,
                    Params = txt_arguments.Text,
                    Extensions = new string[]{}
                };
            app.Name = Path.GetFileName( app.Path.ToString()) + app.Params;
            app.IconPath = app.Path;
            list_custom_items.Items.Add(
                new ListViewItem( app.Name ) {
                    Tag = app
                } );
        }

        private void btn_saveit_Click( object sender, EventArgs e ) {
            Globals.Config.Custom.Apps =
                list_custom_items.Items.OfType<ListViewItem>().Select( a => a.Tag ).OfType<App>().ToArray();

            var configpath = Path.Combine(
                Path.GetDirectoryName( AssemblyInfoHelper.CurrentAssembly.Location ),
                "configs",
                "list.xml" );
            
            Globals.Config.Save( configpath );
            Close();
        }
    }
}
