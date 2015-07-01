using System;
using System.Drawing;
using System.Linq;
using glSDK.Pocos;
using glSDK.UI.LauncherForms;
using glSDK.UI.ModernUITemplate;
using glSDK.UI.SystemForms;
using glSDK.UI.SystemForms.Compiller;
using MetroFramework.Controls;

namespace glSDK.UI {
    public partial class FrmMain : FrmTmp {
        public FrmMain() { InitializeComponent(); }
        private void ShowLauncher(string name) => ShowForm( new FrmLauncher { Category = Program.Apps.Categories.FirstOrDefault( a => a.Name == name ) } );
        private void metroTileGit_Click( object sender, System.EventArgs e ) => ShowForm( new FrmGitClone() );
        private void FmMain_Load( object sender, System.EventArgs e ) => FocusMe();
        private void metroTileAbout_Click( object sender, System.EventArgs e ) => new FrmAbout().ShowDialog();
        private void metroTile1_Click( object sender, System.EventArgs e ) => ShowLauncher( "Editors" );
        private void metroTileSettings_Click( object sender, System.EventArgs e ) => ShowForm( new FrmSettings() );
        private void metroTileFemLinks_Click( object sender, System.EventArgs e ) => ShowForm( new FrmLinks() );
        private void metroTileMapping_Click( object sender, EventArgs e ) => ShowLauncher( "Mapping" );

        private void metroTileCompiling_Click( object sender, EventArgs e ) {
            var f = new FrmLauncher();
            var btn = new MetroTile() { Size = new Size( 90, 90 ), Location = new Point( 23, 63 ), Text = "Compilers", Visible = true };
            btn.Click += (a,b)=>f.ShowForm( new FrmDatCompillerProfile() );
            f.Offset = 1;
            f.Category = Program.Apps.Categories.FirstOrDefault( a => a.Name == "Compilling and Decompilling");
            f.Controls.Add( btn );
            ShowForm( f );
        }

        private void metroTileContent_Click( object sender, EventArgs e ) => ShowLauncher( "Content Managment" );
        private void metroTileModeling_Click( object sender, EventArgs e ) => ShowLauncher( "Modeling" );
        private void metroTileTexturing_Click( object sender, EventArgs e ) => ShowLauncher( "Texturing" );
        private void metroTileModing_Click( object sender, EventArgs e ) => ShowLauncher( "Modding" );
        private void metroTileManuals_Click( object sender, EventArgs e ) => ShowLauncher( "Help and Manuals" );
        private void metroTileOther_Click( object sender, EventArgs e ) => ShowLauncher( "Other" );
        private void button1_Click( object sender, EventArgs e ) => ShowForm( new FrmDatCompiller() );
    }
}