using System;
using System.Diagnostics;
using glSDK.UI.ModernUITemplate;

namespace glSDK.UI.SystemForms
{
    public partial class FrmLinks : FrmTmp
    {
        public FrmLinks()
        {
            InitializeComponent();
        }

        private void FrmLinks_Load(object sender, EventArgs e)
        {
            FocusMe();
        }

        private void metroLinkZHLT_Click(object sender, EventArgs e)
        {
            Process.Start("http://zhlt.info/download-zhlt.html");
        }

        private void metroLinkHlLab_Click(object sender, EventArgs e)
        {
            Process.Start("http://gamer-lab.com/");
        }

        private void metroLinkCMS_Click(object sender, EventArgs e)
        {
            Process.Start("http://cs-mapping.com.ua/");
        }

        private void metroLinkAGHL_Click(object sender, EventArgs e)
        {
            Process.Start("http://aghl.ru/forum/");
        }

        private void metroLinkCSMF_Click(object sender, EventArgs e)
        {
            Process.Start("http://forum.csmania.ru/");
        }

        private void metroLinkDM_Click(object sender, EventArgs e)
        {
            Process.Start("http://cs-mapper.com/");
        }

        private void metroLinkEMG_Click(object sender, EventArgs e)
        {
            Process.Start("https://ww.epicm.org/");
        }
    }
}
