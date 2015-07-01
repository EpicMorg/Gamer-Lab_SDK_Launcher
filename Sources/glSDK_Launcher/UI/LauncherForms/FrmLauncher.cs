using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using glSDK.Pocos;
using glSDK.UI.ModernUITemplate;
using glSDK.UI.SystemForms;
using glSDK.UI.SystemForms.Compiller;
using MetroFramework.Controls;

namespace glSDK.UI.LauncherForms
{
    public partial class FrmLauncher : FrmTmp
    {
        private Category _category;
        public int Offset { get; set; } =0;
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                UpdateBindings();
            }
        }

        private void UpdateBindings() {
            this.DataBindings.Clear();
            this.DataBindings.Add( nameof( Text ), Category, nameof( Category.Name ) );
            var apps = Category.Apps
                .Select( a=>new App() {Name = a.Name, Path = Path.Combine( Constants.RootPath, a.Path )} )
                .Where( a=>File.Exists( a.Path ) )
                .ToList();
            this.SuspendLayout();
            for ( int i = Offset; i < apps.Count+Offset; i++ ) {
                var app = apps[ i ];
                const int size = 90;
                var btn = new MetroTile() {
                    Size = new Size( size, size ),
                    Location = new Point( 23 + ( 10 + size ) * ( i % 4 ), 63 + ( 10 + size ) * ( i / 4 ) ),
                    Text = app.Name,
                    TextAlign = ContentAlignment.BottomCenter,
                    Visible = true
                };
                btn.Click += ( a, b ) => Process.Start( app.Path );
                Controls.Add( btn );
            }
            if ( apps.Count > 16 ) this.AutoScroll = true;
            this.ResumeLayout();
        }

        public FrmLauncher() { InitializeComponent(); }
        private void metroTileCompile_Click(object sender, EventArgs e) => ShowForm( new FrmDatCompiller() );
    }
}