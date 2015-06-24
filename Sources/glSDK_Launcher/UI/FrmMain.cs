using System.Windows.Forms;

namespace glSDK.UI
{
    public partial class FrmMain : SettableForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void metroTileGit_Click(object sender, System.EventArgs e)
        {
            var frmGit = new FrmGitClone();
            Hide();
            frmGit.ShowDialog();
            Show();
            FocusMe();
        }
    }
}
