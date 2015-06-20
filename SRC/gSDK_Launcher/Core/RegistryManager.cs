using System.Windows.Forms;
using Microsoft.Win32;
namespace gSDK_Launcher.Core {
    public static class RegistryHelper {
        public static RegistryKey OOC( this RegistryKey k, string subkey ) {
            return k.OpenSubKey( subkey, true ) ?? k.CreateSubKey( subkey );
        }
    }

    public class ProgID {
        public string Command { get; set; }
        public string IconPath { get; set; }
        public string Name { get; set; }

        public void Save() {
            var cur = Registry.ClassesRoot.OOC( Name );
            var icon = cur.OOC( "DefaultIcon" );
            icon.SetValue( "", IconPath );
            icon.Close();
            var command = cur.OOC( "shell" ).OOC( "open" ).OOC( "command" );
            command.SetValue( "", string.Format( "\"{0}\" \"%1\"", Command ) );
            command.Close();
            cur.Close();
        }
    }

    public class Ext {
        public string Extension { get; set; }
        public string ProgID { get; set; }
        public string IconPath { get; set; }
        public void Save() {
            if ( string.IsNullOrEmpty( ProgID ) ) {
                Registry.ClassesRoot.DeleteSubKeyTree( "." + Extension, false );
                return;
            }
            var cur = Registry.ClassesRoot.OOC( "." + Extension );
            cur.SetValue( "", ProgID );
            if ( !string.IsNullOrEmpty( IconPath ) ) {
                var icon = cur.OOC( "DefaultIcon" );
                icon.SetValue( "", IconPath );
                icon.Close();
            }
            cur.Close();
        }

        public static string GetCurrentProgID( string ext ) {
            var cur = Registry.ClassesRoot.OpenSubKey( "." + ext );
            return cur != null ? cur.GetValue( "" ) as string : null;
        }
    }
}
