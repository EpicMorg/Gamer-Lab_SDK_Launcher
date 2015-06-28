using System;
using System.Windows.Forms;
using glSDK.UI.ModernUITemplate;

namespace glSDK.UI.SystemForms.Compiller
{
    public partial class FrmDatCompillerProfile : FrmTmp
    {
        public FrmDatCompillerProfile()
        {
            InitializeComponent();
        }

        private void FrmDatCompillerProfile_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonCSGexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QCSG|qcsg.exe|HLCSG|hlcsg.exe|*.exe|*.exe"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxCSGexecutablePath.Text =  open.FileName; 
            }
        }

        private void metroButtonBSPexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QBSP|qbsp.exe|QBSP 2|qbsp2.exe|HLBSP|hlbsp.exe|*.exe|*.exe"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxBSPexecutablePath.Text =  open.FileName; 
            }
        }

        private void metroButtonVISexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QVIS|qvis.exe|VIS|vis.exe|HLVIS|hlvis.exe|*.exe|*.exe"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxVISexecutablePath.Text =  open.FileName; 
            }
        }

        private void metroButtonRADexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QRAD|qrad.exe|HLRAD|hlrad.exe|HLRAD 64bit|hlrad_x64.exe|*.exe|*.exe"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
               metroTextBoxRADexecutablePath.Text =  open.FileName; 
            }
        }

        private void metroButtonGameExePath_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxGameExePath.Text = open.SelectedPath;
            }
        }

        private void metroButtonModDirPath_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxModDirPath.Text = open.SelectedPath;
            }
        }
    }
}
