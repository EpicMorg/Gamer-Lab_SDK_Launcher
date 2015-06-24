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
    }
}
