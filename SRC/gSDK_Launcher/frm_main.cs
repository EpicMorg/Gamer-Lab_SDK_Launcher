using gSDK_vgui;
using System.Windows.Forms;

namespace gSDK_Launcher {
    public partial class frm_main : frm_template {
        public frm_main() {
            InitializeComponent();
        }

        private void btn_about_Click(object sender, System.EventArgs e) {
            frm_about frmabout = new frm_about();
            frmabout.ShowDialog();
        }
    }
}
