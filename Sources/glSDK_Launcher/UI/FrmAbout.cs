using System;
using MetroFramework;
using MetroFramework.Forms;


namespace glSDK.UI
{
    public partial class FrmAbout : MetroForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonCredits_Click(object sender, EventArgs e)
        {
            var frm = new FrmCredits();
            frm.ShowDialog();
        }
    }
}
