using System;
using System.Diagnostics;
using glSDK.UI.ModernUITemplate;

namespace glSDK.UI.SystemForms
{
    public partial class FrmThirdPatrySoft : FrmTmp

    {
        public FrmThirdPatrySoft()
        {
            InitializeComponent();
   
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroLinkMetroFramework_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/viperneo/winforms-modernui");
            Process.Start("http://viperneo.github.io/winforms-modernui/");
            Process.Start("http://www.nuget.org/packages/ModernUI/");
        }

        private void metroLinkModernUIIcons_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Templarian/WindowsIcons/");
            Process.Start("http://modernuiicons.com/");
        }

        private void metroLinklibgit2sharp_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/libgit2/libgit2sharp");
            Process.Start("http://www.nuget.org/packages/LibGit2Sharp");
        }

        private void metroLinkMIT1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/viperneo/winforms-modernui/blob/master/LICENSE.md");
        }

        private void metroLinkMIT2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Templarian/WindowsIcons/blob/master/WindowsRT/license.txt");
        }

        private void metroLinkMIT3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/libgit2/libgit2sharp/blob/master/LICENSE.md");
        }

        private void FrmThirdPatrySoft_Load(object sender, EventArgs e)
        {
            FocusMe();
        }
    }
}
