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
using System.Drawing; 
using System.Windows.Forms;

namespace gSDK_vgui {
    public partial class frm_template : Form {
       

        public frm_template() {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region design_hack
        //Resize when border = none + drag
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 25;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e) {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, 32);
            // e.Graphics.FillRectangle(Brushes.DarkBlue, rc); //----> debug
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //---
        #endregion
          
        #region controls_custom
        #region btn_min
        private void pic_btn_min_MouseEnter(object sender, EventArgs e) {
            pic_btn_min.Image = Properties.Resources.min_button;
        } 
        private void pic_btn_min_MouseLeave(object sender, EventArgs e) {
            pic_btn_min.Image = Properties.Resources.min_button_na;
        } 
        private void pic_btn_min_MouseDown(object sender, MouseEventArgs e) {
            pic_btn_min.Image = Properties.Resources.min_button_a; 
        } 
        private void pic_btn_min_MouseClick(object sender, MouseEventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
         
        #region btn_max
        private void pic_max_btn_MouseEnter(object sender, EventArgs e) {
            pic_btn_max.Image = Properties.Resources.max_button;
        } 
        private void pic_btn_max_MouseLeave(object sender, EventArgs e) {
            pic_btn_max.Image = Properties.Resources.max_button_na;
        } 
        private void pic_btn_max_MouseDown(object sender, MouseEventArgs e) {
            pic_btn_max.Image = Properties.Resources.max_button_a;
        } 
        private void pic_btn_max_MouseClick(object sender, MouseEventArgs e) {

            this.WindowState = this.WindowState == FormWindowState.Normal ?
            FormWindowState.Maximized :
            FormWindowState.Normal;
        }
        #endregion

        #region btn_exit
        private void pic_btn_exit_MouseEnter(object sender, EventArgs e) {
            pic_btn_exit.Image = Properties.Resources.exit_button;
        }
        private void pic_btn_exit_MouseLeave(object sender, EventArgs e) {
            pic_btn_exit.Image = Properties.Resources.exit_button_na;
        }
        private void pic_btn_exit_MouseDown(object sender, MouseEventArgs e) {
            pic_btn_exit.Image = Properties.Resources.exit_button_a;
        }
        private void pic_btn_exit_MouseClick(object sender, MouseEventArgs e) {
            Application.Exit();
        }
        #endregion
        #endregion

        private void frm_template_Load(object sender, EventArgs e) {

        } 
        public override string Text {
            get { return base.Text; }
            set {
                base.Text = value;
                this.lbl_title.Text = value;
            }  
        }
         
    }
}
