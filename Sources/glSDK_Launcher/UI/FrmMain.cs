using System;
using glSDK.UI.LauncherForms;
using glSDK.UI.ModernUITemplate;
using glSDK.UI.SystemForms;

namespace glSDK.UI
{
    /// <summary>
    /// </summary>
    public partial class FrmMain : FrmTmp
    {
        /// <summary>
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileGit_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmGitClone();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmMain_Load(object sender, System.EventArgs e)
        {
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileAbout_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmAbout();
            frm.ShowDialog();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmEditors();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileSettings_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmSettings();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileFemLinks_Click(object sender, System.EventArgs e)
        {
            var frm = new FrmLinks();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileMapping_Click(object sender, EventArgs e)
        {
            var frm = new FrmMapping();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileCompiling_Click(object sender, EventArgs e)
        {
            var frm = new FrmCompiling();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileContent_Click(object sender, EventArgs e)
        {
            var frm = new FrmContent();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileModeling_Click(object sender, EventArgs e)
        {
            var frm = new FrmModelling();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileTexturing_Click(object sender, EventArgs e)
        {
            var frm = new FrmTexturing();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileModing_Click(object sender, EventArgs e)
        {
            var frm = new FrmModding();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTileManuals_Click(object sender, EventArgs e)
        {
            var frm = new FrmManuals();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }

        private void metroTileOther_Click(object sender, EventArgs e)
        {
            var frm = new FrmOther();
            Hide();
            frm.ShowDialog();
            Show();
            FocusMe();
        }
    }
}