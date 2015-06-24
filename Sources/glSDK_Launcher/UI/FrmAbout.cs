using System;
using System.Reflection;
using MetroFramework.Forms;


namespace glSDK.UI
{
    public partial class FrmAbout : MetroForm
    {
        public FrmAbout()
        {
            InitializeComponent();
            metroLabelCopy.Text = AssemblyCopyright;
            metroLabelVer.Text = AssemblyVersion;
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {

        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        private void metroButtonCredits_Click(object sender, EventArgs e)
        {
            var frm = new FrmCredits();
            frm.ShowDialog();
        }

        private void metroButtonOther_Click(object sender, EventArgs e)
        {
            var frm = new FrmThirdPatrySoft();
            frm.ShowDialog();
        }
    }
}
