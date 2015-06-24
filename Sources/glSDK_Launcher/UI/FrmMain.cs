using System;
using glSDK.UI.LauncherForms;
using glSDK.UI.ModernUITemplate;
using glSDK.UI.SystemForms;

namespace glSDK.UI
{
    public partial class FrmMain : FrmTmp
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void metroTileGit_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmGitClone();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            FocusMe();
        }

        private void metroTileAbout_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmEditors();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileSettings_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmSettings();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileFrmLinks_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmLinks();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileMapping_Click(object sender, EventArgs e)
        {
            var frm = new FrmMapping();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileCompiling_Click(object sender, EventArgs e)
        {
            var frm = new FrmCompiling();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileContent_Click(object sender, EventArgs e)
        {
            var frm = new FrmContent();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileModelling_Click(object sender, EventArgs e)
        {
            var frm = new FrmModelling();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }
    }
}