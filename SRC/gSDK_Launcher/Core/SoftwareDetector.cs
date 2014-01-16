using System;
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
            var p = app.Path.ToString();
            var r = File.Exists( p )||Directory.Exists( p );
            return r;
        }
        /// <summary>
        /// Check all app in category and set 'installed' flag to real value
        /// </summary>
        public static void CheckAllInCategory( Category c ) {
            try {
                foreach (var app in c.Apps)
                    app.Installed = CheckAppInstalled( app );
            }
            catch (Exception ex) {
                
            }
        }

        public static void CheckAllInConfig( Config c ) {
            foreach ( var category in c.Apps )
                CheckAllInCategory( category );
        }
    }
}
