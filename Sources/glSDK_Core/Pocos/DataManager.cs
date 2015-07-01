using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace glSDK.Pocos
{
    public static class DataManager
    {
        private static readonly XmlSerializer AppsSerializer = new XmlSerializer(typeof(Apps));
        private static readonly XmlSerializer CompilersSerializer = new XmlSerializer(typeof(Compilers));
        public static readonly XmlSerializer SettingsSerializer = new XmlSerializer(typeof(Settings));

        public static Settings LoadSettings(string file)
        {
            using (var f = File.OpenRead(file)) return (Settings)SettingsSerializer.Deserialize(f);
        }

        public static void SaveSettings(string file, Settings settings)
        {
            using (var f = File.OpenWrite(file))
            {
                f.SetLength(0);
                SettingsSerializer.Serialize(f, settings);
            }
        }

        public static Apps LoadApps( string file ) {
            using ( var f = File.OpenRead( file ) ) return (Apps) AppsSerializer.Deserialize( f );
        }

        public static void SaveApps( string file, Apps apps ) {
            using ( var f = File.OpenWrite( file ) ) {
                f.SetLength( 0 );
                AppsSerializer.Serialize( f, apps );
            }
        }
        public static void SaveCompilers(string file, Compilers apps)
        {
            using ( var f = File.OpenWrite( file ) ) {
                f.SetLength( 0 );
                CompilersSerializer.Serialize(f, apps);
            }
        }

        public static Compilers LoadCompilers( string file ) {
            using (var f = File.OpenRead(file)) return (Compilers)CompilersSerializer.Deserialize(f);
        }
    }
}
