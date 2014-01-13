using System.IO;
namespace gSDK_Launcher {
    class SoftwareDetector {
        public bool CheckAppInstalled(App app) {
            return File.Exists( app.Path );
        }
        /// <summary>
        /// Check all app in category and set 'installed' flag to real value
        /// </summary>
        public void CheckAllInCategory(Category c) {
            foreach (var app in c.Apps)
                app.Installed = this.CheckAppInstalled( app );
        }

        public void CheckAllInConfig( Config c ) {
            foreach (var category in c.Apps)
                this.CheckAllInCategory( category );
        }
    }
}
