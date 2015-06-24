using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using LibGit2Sharp;


namespace glSDK.UI
{
    public partial class FrmGitClone : SettableForm
    {
        public FrmGitClone()
        {
            InitializeComponent();
            metroComboBoxGit.SelectedIndex = 0;
        }

        private void FrmGitClone_Load(object sender, EventArgs e)
        {
          
        }

        private void metroBtnGitClone_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            switch (metroComboBoxGit.SelectedIndex)
            {
                //Launcher, 0
                //Half - Life SDK(Steam, Official), 1
                //Half - Life SDK(Valve Git, Official), 2
                //Source SDK (Valve Git, Official), 3
                //OpenVR SDK(Valve Git, Official), 4
                case 0:
                    folder.ShowDialog();
                    try {Repository.Clone("https://github.com/EpicMorg/Gamer-Lab_SDK_Launcher.git", folder.SelectedPath);}
                    catch (Exception ex) {Console.WriteLine(ex); }  // dev >> null 
                    finally { MessageBox.Show(@"OK"); }
                    break;
                case 1:
                    try { Process.Start("steam://install/254430"); }
                    catch (Exception ex) { Console.WriteLine(ex); } // dev >> null 
                    break;
                case 2:
                    folder.ShowDialog();
                    try { Repository.Clone("https://github.com/ValveSoftware/halflife.git", folder.SelectedPath); }
                    catch (Exception ex) { Console.WriteLine(ex); }  // dev >> null 
                    finally { MessageBox.Show(@"OK"); }
                    break;
                case 3:
                    folder.ShowDialog();
                    try { Repository.Clone("https://github.com/ValveSoftware/source-sdk-2013.git", folder.SelectedPath); }
                    catch (Exception ex) { Console.WriteLine(ex); }  // dev >> null 
                    finally { MessageBox.Show(@"OK"); }
                    break;
                case 4:
                    folder.ShowDialog();
                    try { Repository.Clone("https://github.com/ValveSoftware/openvr.git", folder.SelectedPath); }
                    catch (Exception ex) { Console.WriteLine(ex); }  // dev >> null 
                    finally { MessageBox.Show(@"OK"); }
                    break;
            }
        }
    }
}
