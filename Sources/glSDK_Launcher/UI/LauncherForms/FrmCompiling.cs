using System;
using glSDK.UI.ModernUITemplate;
using glSDK.UI.SystemForms;
using glSDK.UI.SystemForms.Compiller;

namespace glSDK.UI.LauncherForms
{
    public partial class FrmCompiling : FrmTmp
    {
        public FrmCompiling()
        {
            InitializeComponent();
        }

        private void FrmCompiling_Load(object sender, EventArgs e)
        {
        }

        private void metroTileCompile_Click(object sender, EventArgs e)
        {
            var frm = new FrmDatCompiller();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }
    }
}