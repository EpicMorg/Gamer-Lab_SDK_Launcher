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
using System.Diagnostics;
using gSDK_vgui;

namespace gSDK_Launcher {
    public partial class frm_credits : frm_template {
        public frm_credits() {
            InitializeComponent();
        }

        private void frm_credits_Load(object sender, EventArgs e) {

        }

        private void btn_ok_Click(object sender, EventArgs e) { 
            this.Close(); 
        }

        private void pic_logotype_Click(object sender, EventArgs e) {
            Process.Start("http://hl-lab.ru");
        }

        private void link_stam_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/stamepicmorg");
        }

        private void link_kasthack_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/kasthack");
        }

        private void link_serj_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://hl-lab.ru/rus/%D0%A1%D0%B5%D1%80%D0%B3%D0%B5%D0%B9");
        }

        private void link_neo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://hl-lab.ru/rus/user/NEO");
        }
 
    }
}
