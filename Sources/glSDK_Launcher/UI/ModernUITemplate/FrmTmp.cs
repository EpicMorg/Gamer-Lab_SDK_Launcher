using System;
using MetroFramework.Forms;

namespace glSDK.UI.ModernUITemplate
{
    public partial class FrmTmp : MetroForm
    {
        public FrmTmp()
        {
            InitializeComponent();
        }
        internal void ShowForm(FrmTmp form)
        {
            Hide();
            form.ShowDialog();
            Show();
            FocusMe();
        }
        private void FrmTmp_Load(object sender, EventArgs e)
        {
            //Theme = Program.Settings.Theme;
        }
    }
}
