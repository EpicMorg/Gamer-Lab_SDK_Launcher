using System.Windows.Forms;
using glSDK.UI.ModernUITemplate;
using MetroFramework;

namespace glSDK.UI.SystemForms
{
    public partial class FrmSettings : FrmTmp
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {
            FocusMe();
        }

        private void metroButtonReset_Click(object sender, System.EventArgs e)
        {
            MetroMessageBox.Show(this, "This option will reset settings to defaults. Are you sure?", "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void metroButtonSave_Click(object sender, System.EventArgs e)
        {
            MetroMessageBox.Show(this, "Saved", "Save settings", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
