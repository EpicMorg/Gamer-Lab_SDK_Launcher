using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using glSDK.LOCALE;
using glSDK.Pocos;
using glSDK.UI.ModernUITemplate;

namespace glSDK.UI.SystemForms.Compiller {
    public partial class FrmDatCompiller : FrmTmp {
        public FrmDatCompiller() { InitializeComponent(); }

        private void FrmDatCompiller_Load( object sender, EventArgs e ) { UpdateCompilers(); }

        private void UpdateCompilers() {
            cmbProfile.DataSource = null;
            cmbProfile.DataSource = DataManager.LoadCompilers( Constants.CompilersPath ).Profiles;
        }

        private void metroButtonEditProfile_Click( object sender, EventArgs e ) {
            var frm = new FrmDatCompillerProfile();
            frm.ShowDialog();
        }

        private void metroButtonBrowse_Click( object sender, EventArgs e ) {
            var open = new OpenFileDialog { CheckFileExists = true, CheckPathExists = true, Filter = @"MAP|*.map" };

            if ( open.ShowDialog() == DialogResult.OK ) metroTextBoxBrowse.Text = open.FileName;
        }

        private async void metroTile1_Click( object sender, EventArgs e ) {
            var mapfile = metroTextBoxBrowse.Text;
            var profile = cmbProfile.SelectedItem as Profile;
            var runAfter = chkRun.Checked;

            if ( !File.Exists( mapfile ) ) {
                MessageBox.Show( Strings.FrmDatCompiller_metroTile1_Click_Map_file_doesn_t_exist );
                return;
            }
            
            if ( profile == null ) {
                MessageBox.Show( Strings.FrmDatCompiller_metroTile1_Click_No_profile_selected );
                return;
            }
            if ( !File.Exists( profile.Csg?.Path )
                 && !MissingCompiler( "CSG" ) ) return;
            if ( !File.Exists( profile.Bsp?.Path )
                 && !MissingCompiler( "BSP" ) ) return;
            if ( !File.Exists( profile.Rad?.Path )
                 && !MissingCompiler( "RAD" ) ) return;
            if ( !File.Exists( profile.Vis?.Path )
                 && !MissingCompiler( "VIS" ) ) return;
            if ( !Directory.Exists( profile.Mod ) ) {
                MessageBox.Show( "Mod path doesn't exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            if ( runAfter && !File.Exists( profile.Game.Path ) ) {
                MessageBox.Show(
                    "You've decided to run game after compilation but path to game is missing/incorrect",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                return;
            }
            metroTile1.Enabled = false;
            await Compile( mapfile, profile );
            if ( runAfter ) RunGame(mapfile, profile);
            metroTile1.Enabled = true;
        }

        private void RunGame(string mapfile, Profile profile) {
            var modname = Path.GetFileName( profile.Mod );
            var map = Path.GetFileNameWithoutExtension( mapfile );
            var userargs = "profile.Game.Params";
            var proc = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = profile.Game.Path,
                    Arguments = $"-game {modname} +map {map} {userargs}",
                    WorkingDirectory = Path.GetDirectoryName(profile.Game.Path)
                }
            };
            proc.Start();
        }

        private async Task Compile( string mapfile, Profile profile ) {
            foreach ( var compiler in new[] { profile.Csg, profile.Bsp, profile.Vis, profile.Rad } ) {
                if ( await ExecuteCompiler( compiler, mapfile ) != 0 ) {
                    MessageBox.Show( "Compiler returned and error code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }
            }
            foreach (
                var p in
                    new[] { "b0", "b1", "b2", "b3", "hsz", "p0", "p1", "p2", "p3", "pln", "prt", "wa_","log" }.Select(
                        ext => mapfile + "." + ext ).Where( p => File.Exists( p ) ) ) File.Delete( p );
            CopyMap( mapfile, profile );
        }

        private static void CopyMap( string mapfile, Profile profile ) {
            var fn = Path.GetFileNameWithoutExtension( mapfile ) + ".bsp";
            var src = Path.Combine( Path.GetDirectoryName( mapfile ), fn );
            var modname = Path.GetFileName( Path.GetDirectoryName( profile.Mod ) );
            var dest = Path.Combine( Path.GetDirectoryName( profile.Game.Path ), modname, "maps", fn );
            File.Copy( src, dest );
            File.Delete( src );
        }

        private async Task<int> ExecuteCompiler( Command compiler, string mapfile ) {
            if ( !File.Exists( compiler.Path ) ) return 0;
            var proc = new Process {
                StartInfo =
                    new ProcessStartInfo {
                        FileName = compiler.Path,
                        Arguments = compiler.Params,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Minimized,
                        WorkingDirectory = Path.GetDirectoryName( mapfile )
                    }
            };
            proc.Start();
            await Task.WhenAll( StartRead( proc.StandardOutput ), StartRead( proc.StandardError ) );
            proc.WaitForExit();
            return proc.ExitCode;
        }

        private async Task StartRead( StreamReader stream ) {
            var c = new char[16];
            int read;
            while ( ( read = await stream.ReadAsync( c, 0, c.Length ) ) != 0 ) txtLog.AppendText( new string( c, 0, read ) );
        }

        private bool MissingCompiler( string name ) {
            return MessageBox.Show(
                String.Format( Strings.NoValidCompilerSpecified, name),
                Strings.FrmDatCompiller_MissingCompiler_Warning,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning ) == DialogResult.Yes;
        }
    }
}