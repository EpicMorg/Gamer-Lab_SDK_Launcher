﻿using System;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace glSDK.UI
{
    public partial class SettableForm : MetroForm
    {
        public SettableForm()

        {
            InitializeComponent();
           // var iface = CoreHandler.Instance.Config.Interface;
            var sm = new MetroStyleManager();
            sm.Owner = this;
            this.StyleManager = sm;
           // this.Style = sm.Style = iface.Style;
           // this.Theme = sm.Theme = iface.Theme;
        }

        //private void InitializeComponent()
        //{
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettableForm));
        //    this.SuspendLayout();
        //    // 
        //    // SettableForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(300, 300);
        //   // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        //    this.Name = "SettableForm";
        //    this.Load += new System.EventHandler(this.SettableForm_Load);
        //    this.ResumeLayout(false);

        //}


        private void SettableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
