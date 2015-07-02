using System;
using System.Windows.Forms;
using glSDK.UI.ModernUITemplate;
using glSDK.Pocos;
using MetroFramework.Controls;

namespace glSDK.UI.SystemForms.Compiller
{
    public partial class FrmDatCompillerProfile : FrmTmp
    {
        private Compilers compilers;
        public FrmDatCompillerProfile()
        {
            InitializeComponent();
            compilers = DataManager.LoadCompilers(Constants.CompilersPath);
            dgvProfiles.AutoGenerateColumns = false;
            UpdateProfiles();
        }

        private void UpdateProfiles() {
            dgvProfiles.DataSource = null;
            dgvProfiles.DataSource = compilers.Profiles;
        }

        private void UpdateBindings(Profile profile)
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add(nameof(txtName.Text), profile, nameof(profile.Name));
            
            txtMod.DataBindings.Clear();
            txtMod.DataBindings.Add(nameof(txtMod.Text), profile, nameof(profile.Mod));
            BindCommand( profile.Game, txtGameExe, txtGameArgs );
            BindCommand(profile.Csg, txtCsgPath, txtCsgArgs);
            BindCommand(profile.Bsp, txtBspPath, txtBspArgs);
            BindCommand(profile.Vis, txtVisPath, txtVisArgs);
            BindCommand(profile.Rad, txtRadPath, txtRadArgs);
        }
        private static void BindCommand(Command csg, Control txtPath, Control txtArgs)
        {
            if (csg == null) return;
            txtPath.DataBindings.Clear();
            txtPath.DataBindings.Add(nameof(txtPath.Text), csg, nameof(csg.Path));
            txtArgs.DataBindings.Clear();
            txtArgs.DataBindings.Add(nameof(txtArgs.Text), csg, nameof(csg.Params));
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
            if ( open.ShowDialog() == DialogResult.OK ) txtCsgPath.Text = open.FileName;
        }
        private void metroButtonBSPexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QBSP|qbsp.exe|QBSP 2|qbsp2.exe|HLBSP|hlbsp.exe|*.exe|*.exe"
            };
            if ( open.ShowDialog() == DialogResult.OK ) txtBspPath.Text = open.FileName;
        }
        private void metroButtonVISexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QVIS|qvis.exe|VIS|vis.exe|HLVIS|hlvis.exe|*.exe|*.exe"
            };
            if ( open.ShowDialog() == DialogResult.OK ) txtVisPath.Text = open.FileName;
        }
        private void metroButtonRADexecutablePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"QRAD|qrad.exe|HLRAD|hlrad.exe|HLRAD 64bit|hlrad_x64.exe|*.exe|*.exe"
            };
            if ( open.ShowDialog() == DialogResult.OK ) txtRadPath.Text = open.FileName;
        }
        private void metroButtonGameExePath_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = @"HL.exe|hl.exe"
            };
            if ( open.ShowDialog() == DialogResult.OK ) txtGameExe.Text = open.FileName;
        }
        private void metroButtonModDirPath_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog();
            if ( open.ShowDialog() == DialogResult.OK ) txtMod.Text = open.SelectedPath;
        }
        private void dgvProfiles_SelectionChanged(object sender, EventArgs e)
        {
            //var rows = dgvProfiles.SelectedRows;
            //if (rows.Count < 0) { 
            //    var data = (Profile) rows[ 0 ].DataBoundItem;
            //    UpdateBindings( data );
            //}
        }
        private void dgvProfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvProfiles.Rows[e.RowIndex].DataBoundItem as Profile;
            if (data != null)
                UpdateBindings(data);
        }
        
        private void metroButtonAddNewName_Click(object sender, EventArgs e)
        {
            var add = new Profile();
            compilers.Profiles.Add( add );
            UpdateBindings( add );
        }

        private void metroButtonDelete_Click( object sender, EventArgs e ) {
            var sel = dgvProfiles.SelectedRows;
            if ( sel.Count == 0 ) return;
            //UpdateBindings( sel[0].DataBoundItem as Profile );
            compilers.Profiles.Remove( sel[ 0 ].DataBoundItem as Profile );
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            UpdateProfiles();
            compilers.OnPropertyChanged(nameof(Compilers.Profiles));
            DataManager.SaveCompilers(Constants.CompilersPath, compilers);
        }
    }
}
