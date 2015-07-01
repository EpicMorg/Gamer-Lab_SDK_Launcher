using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using glSDK.Pocos;
using glSDK.UI;
using glSDK.UI.SystemForms;
using glSDK.UI.SystemForms.Compiller;

namespace glSDK {
    internal static class Program {
        public static Apps Apps { get; set; }
        public static Settings Settings { get; set; }
        
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            LoadSettings();
            Application.Run(new FrmMain());
        }

        public static void LoadSettings() {
            var settingsPath = Constants.SettingsPath;
            var currentThread = Thread.CurrentThread;

            if ( !File.Exists( settingsPath ) ) DataManager.SaveSettings( settingsPath, new Settings() { Language = currentThread.CurrentUICulture.Name } );

            Settings = DataManager.LoadSettings( settingsPath );
            var l = Settings.Language;
            if ( !String.IsNullOrWhiteSpace( l ) ) currentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo( l );
            Apps = DataManager.LoadApps( Constants.AppsPath );
        }
    }
}