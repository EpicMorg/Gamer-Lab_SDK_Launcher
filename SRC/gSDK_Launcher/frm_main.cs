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
using gSDK_vgui;
using System.Windows.Forms;

namespace gSDK_Launcher {
    public partial class frm_main : frm_template {
        public frm_main() {
            InitializeComponent();
        }
        private void btn_about_Click(object sender, System.EventArgs e) {
            new frm_about().ShowDialog();
        }
        private void button1_Click(object sender, System.EventArgs e) {
            new frm_scanning().ShowDialog();
        }
        private void btn_settings_Click(object sender, System.EventArgs e) {
           new frm_settings().ShowDialog();
        }
        private void btn_exit_Click(object sender, System.EventArgs e) {
            Application.Exit();
        }
        private void frm_main_Load(object sender, System.EventArgs e) {}
    }
}
