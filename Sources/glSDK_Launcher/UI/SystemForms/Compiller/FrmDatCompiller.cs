using System;
using System.Windows.Forms;
using glSDK.UI.ModernUITemplate;

namespace glSDK.UI.SystemForms.Compiller
{
    public partial class FrmDatCompiller : FrmTmp
    {
        public FrmDatCompiller()
        {
            InitializeComponent();
        }

        private void FrmDatCompiller_Load(object sender, EventArgs e)
        {

        }
 
        private void metroButtonEditProfile_Click(object sender, EventArgs e)
        {
            var frm = new FrmDatCompillerProfile();
            frm.ShowDialog();
        }

        private void metroButtonBrowse_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true, 
                Filter = @"MAP|*.map"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxBrowse.Text =  open.FileName; 
            }
        }
    }
}
