﻿/*
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
using System.Reflection;
namespace gSDK_Launcher {
    public partial class frm_about : FrmTemplate {
        public frm_about() {
            InitializeComponent();
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("{0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.lbl_libver.Text = AssemblyInfoHelper.VGuinfo.GetName().Version.ToString();

        }
        public string AssemblyTitle {
            get {
                var attr = AssemblyInfoHelper.GetAttribute<AssemblyTitleAttribute>();
                return attr != null && attr.Title != ""
                           ? attr.Title
                           : Path.GetFileNameWithoutExtension( AssemblyInfoHelper.CurrentAssembly.CodeBase );
            }
        }
        public string AssemblyVersion {
            get {
                return AssemblyInfoHelper.CurrentAssembly.GetName().Version.ToString();
            }
        }
        public string AssemblyDescription {
            get {
                var attr = AssemblyInfoHelper.GetAttribute<AssemblyDescriptionAttribute>();
                return attr != null ? attr.Description : "";
            }
        }
        public string AssemblyProduct {
            get {
                var attr = AssemblyInfoHelper.GetAttribute<AssemblyProductAttribute>();
                return attr != null ? attr.Product : "";
            }
        }
        public string AssemblyCopyright {
            get {
                var attr = AssemblyInfoHelper.GetAttribute<AssemblyCopyrightAttribute>();
                return attr != null ? attr.Copyright : "";
            }
        }
        public string AssemblyCompany {
            get {
                var attr = AssemblyInfoHelper.GetAttribute<AssemblyCompanyAttribute>();
                return attr != null ? attr.Company : "";
            }
        }
        private void btn_close_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btn_credits_Click(object sender, EventArgs e) {
            var frmCredits = new frm_credits();
            frmCredits.ShowDialog();
        }
        private void frm_about_Load(object sender, EventArgs e) {}
    }
}