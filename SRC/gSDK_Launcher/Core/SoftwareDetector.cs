using System.IO;
using System.Windows.Forms;

namespace gSDK_Launcher {
    public class SoftwareDetector {
        /// <summary>
        /// Path must be relative from sdk installation
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool CheckAppInstalled( App app ) {

            var p = AssemblyInfoHelper.GetPath( app.Path );
            var r = File.Exists( p )||Directory.Exists( p );
            //if ( !r ) MessageBox.Show( p );
            return r;
        }
        /// <summary>
        /// Check all app in category and set 'installed' flag to real value
        /// </summary>
        public static void CheckAllInCategory( Category c ) {
            foreach (var app in c.Apps)
                app.Installed = CheckAppInstalled( app );
        }

        public static void CheckAllInConfig( Config c ) {
            foreach ( var category in c.Apps )
                CheckAllInCategory( category );
        }
    }
}
