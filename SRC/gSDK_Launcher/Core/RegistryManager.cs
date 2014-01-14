using Microsoft.Win32;
namespace gSDK_Launcher.Core {
    public static class RegistryHelper {
        public static RegistryKey OOC( this RegistryKey k, string subkey ) {
            return k.OpenSubKey( subkey ) ?? k.CreateSubKey( subkey );
        }
    }

    public class ProgID {
        public string Command { get; set; }
        public string IconPath { get; set; }
        public string Name { get; set; }

        public void Save() {
            var cur = Registry.ClassesRoot.OOC( this.Name );
            var icon = cur.OOC( "DefaultIcon" );
            icon.SetValue( "", this.IconPath  );
            icon.Close();
            var command = cur.OOC( "shell" ).OOC( "open" ).OOC( "command" );
            command.SetValue( "", string.Format( "\"{0}\" \"%1\"", this.Command ) );
            command.Close();
            cur.Close();
        }
    }

    public class Ext {
        public string Extension { get; set; }
        public string ProgID { get; set; }
        public void Save() {
            var cur = Registry.ClassesRoot.OOC( "."+this.Extension );
            cur.SetValue( "", ProgID );
        }
    }
}
