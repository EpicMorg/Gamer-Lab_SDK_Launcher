using System;
using System.Diagnostics;
using System.Windows.Forms;
using glSDK.LOCALE;
using glSDK.UI.ModernUITemplate;
using LibGit2Sharp;

namespace glSDK.UI.SystemForms {
    public partial class FrmGitClone : FrmTmp {
        public FrmGitClone() { InitializeComponent(); }

        private void FrmGitClone_Load( object sender, EventArgs e ) {
            FocusMe();
            metroComboBoxGit.SelectedIndex = 0;
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Clone;
        }

        #region Design
        private void CloningEffects() {
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Cloning;
            Refresh();
        }

        private void CloneEffects() {
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Clone;
            Refresh();
        }

        private void ClonedEffects() {
            metroBtnGitClone.Text = Strings.Cloned;
            metroProgressBar.Value = 100;
            Refresh();
        }

        private void CanceledEffects() {
            metroBtnGitClone.Text = Strings.Canceled;
            metroProgressBar.Value = 0;
            Refresh();
            timer.Start();
        }

        private void timer_Tick( object sender, EventArgs e ) => CloneEffects();

        private void metroComboBoxGit_SelectedIndexChanged( object sender, EventArgs e ) { CloneEffects(); }
        #endregion

        private void metroBtnGitClone_Click( object sender, EventArgs e ) {
            var folder = new FolderBrowserDialog();
            var urls = new string[] {
                "https://github.com/EpicMorg/Gamer-Lab_SDK_Launcher.git", "https://github.com/ValveSoftware/halflife.git",
                "https://github.com/ValveSoftware/source-sdk-2013.git", "https://github.com/ValveSoftware/openvr.git"
            };
            //"steam://install/254430"
            //todo: steam
            var selecteUrl = urls[ metroComboBoxGit.SelectedIndex ];

            CloningEffects();
            if ( folder.ShowDialog() == DialogResult.OK )
                try {
                    Repository.Clone( selecteUrl, folder.SelectedPath );
                }
                catch ( Exception ex ) {
                    CloneEffects();
                    Console.WriteLine( ex );
                } // dev >> null 
                finally {
                    ClonedEffects();
                }
            else CanceledEffects();
        }
    }
}