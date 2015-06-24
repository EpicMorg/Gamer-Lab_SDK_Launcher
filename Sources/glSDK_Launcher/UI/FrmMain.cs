using System.Windows.Forms;
using glSDK.Properties;
using MetroFramework.Forms;

namespace glSDK.UI
{
    public partial class FrmMain : MetroForm
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
    }
}
