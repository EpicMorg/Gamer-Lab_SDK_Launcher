using System;
using System.Windows.Forms;
using System.Diagnostics;
using LibGit2Sharp;
using glSDK.LOCALE;


namespace glSDK.UI
{
    public partial class FrmGitClone : SettableForm
    {
        public FrmGitClone()
        {
            InitializeComponent();
        }

        private void FrmGitClone_Load(object sender, EventArgs e)
        {
            metroComboBoxGit.SelectedIndex = 0;
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Clone;
        }
        #region Design
        private void CloningEffects()
        {
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Cloning;
            Refresh();
        }
        private void CloneEffects()
        {
            metroProgressBar.Value = 0;
            metroBtnGitClone.Text = Strings.Clone;
            Refresh();
        }
        private void ClonedEffects()
        {
            metroBtnGitClone.Text = Strings.Cloned;
            metroProgressBar.Value = 100;
            Refresh();
        }
        private void CanceledEffects()
        {
            metroBtnGitClone.Text = Strings.Canceled;
            metroProgressBar.Value = 0;
            Refresh();
            timer.Start();
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CloneEffects();
        }
        private void metroComboBoxGit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CloneEffects();
        }
        #endregion
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
                    CloningEffects();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Repository.Clone("https://github.com/EpicMorg/Gamer-Lab_SDK_Launcher.git",
                                folder.SelectedPath);

                        }
                        catch (Exception ex)
                        {
                            CloneEffects();
                            Console.WriteLine(ex);
                        } // dev >> null 
                        finally
                        {
                            ClonedEffects();
                        }
                    }
                    else
                    {
                        CanceledEffects();
                    }
                    break;
                case 1:
                    try { Process.Start("steam://install/254430"); }
                    catch (Exception ex) { Console.WriteLine(ex); } // dev >> null 
                    break;
                case 2:
                    CloningEffects();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Repository.Clone("https://github.com/ValveSoftware/halflife.git",
                                folder.SelectedPath);

                        }
                        catch (Exception ex)
                        {
                            CloneEffects();
                            Console.WriteLine(ex);
                        } // dev >> null 
                        finally
                        {
                            ClonedEffects();
                        }
                    }
                    else
                    {
                        CanceledEffects();
                    }
                    break;
                case 3:
                    CloningEffects();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Repository.Clone("https://github.com/ValveSoftware/source-sdk-2013.git",
                                folder.SelectedPath);

                        }
                        catch (Exception ex)
                        {
                            CloneEffects();
                            Console.WriteLine(ex);
                        } // dev >> null 
                        finally
                        {
                            ClonedEffects();
                        }
                    }
                    else
                    {
                        CanceledEffects();
                    }
                    break;
                case 4:
                    CloningEffects();
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Repository.Clone("https://github.com/ValveSoftware/openvr.git",
                                folder.SelectedPath);

                        }
                        catch (Exception ex)
                        {
                            CloneEffects();
                            Console.WriteLine(ex);
                        } // dev >> null 
                        finally
                        {
                            ClonedEffects();
                        }
                    }
                    else
                    {
                        CanceledEffects();
                    }
                    break;
            }
        }
    }
}
