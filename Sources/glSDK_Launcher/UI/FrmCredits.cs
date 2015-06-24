using System;
using System.Diagnostics;
using MetroFramework.Forms;

namespace glSDK.UI
{
    public partial class FrmCredits : MetroForm
    {
        public FrmCredits()
        {
            InitializeComponent();
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroLinkSTAM_Click(object sender, EventArgs e)
        {
            Process.Start("https://stam.epicm.org/");
        }

        private void metroLinkKST_Click(object sender, EventArgs e)
        {
            Process.Start("https://kasthack.epicm.org/");
        }

        private void metroLinkOlegus_Click(object sender, EventArgs e)
        {
            Process.Start("https://olegus-dark-industries.tk/");
        }

        private void metroLinkSergey_Click(object sender, EventArgs e)
        {
            Process.Start("http://gamer-lab.com/rus/Сергей");
        }

        private void metroLinkCheater_Click(object sender, EventArgs e)
        {
           // Process.Start("");
        }

        private void metroLinkHLCommunity_Click(object sender, EventArgs e)
        {
            Process.Start("http://gamer-lab.com/");
            Process.Start("https://vk.com/hl_lab");
            Process.Start("https://www.facebook.com/groups/hl.lab.ru/");
            Process.Start("http://steamcommunity.com//groups/gamer-lab_com");
        }
    }
}
