using System.IO;
namespace gSDK_Launcher {
    public class SoftwareDetector {
        /// <summary>
        /// Path must be relative from sdk installation
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool CheckAppInstalled( App app ) {
            return File.Exists(
                AssemblyInfoHelper.GetPath(
                    app.Path
                )
            );
        }
        /// <summary>
        /// Check all app in category and set 'installed' flag to real value
        /// </summary>
        public static void CheckAllInCategory( Category c ) {
            foreach ( var app in c.Apps )
                app.Installed = CheckAppInstalled( app );
        }

        public static void CheckAllInConfig( Config c ) {
            foreach ( var category in c.Apps )
                CheckAllInCategory( category );
        }
    }
}
