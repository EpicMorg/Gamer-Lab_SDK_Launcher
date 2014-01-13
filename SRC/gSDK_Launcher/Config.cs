using System.Linq;
using System.Xml;

namespace gSDK_Launcher {
    internal class Helper {
        public static XmlNode GNBN( XmlNode n, string name ) {
            return n.ChildNodes.OfType<XmlNode>().First( a => a.Name == name );
        }
        public static string GNTBN( XmlNode n, string name ) {
            return GNBN( n, name ).InnerText;
        }
    }

    public class Config {
        public Category[] Apps { get; set; }
        public Category Support { get; set; }
        public Config() {}

        public Config( XmlNode n ) {
            this.Apps =
                n.ChildNodes.OfType<XmlNode>()
                    .First( a => a.Name == "apps" )
                    .ChildNodes.OfType<XmlNode>()
                    .Select( a => new Category( a ) )
                    .ToArray();
            this.Support = new Category(
                n.ChildNodes.OfType<XmlNode>().First( a => a.Name == "apps" )
            );
        }

        public static Config Load( string path ) {
            var d = new XmlDocument();
            d.Load( path );
            return new Config( d.DocumentElement);
        }
    }

    public class App {
        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Path { get; set; }
        public string[] Extensions { get; set; }
        public bool Installed { get; set; }
        public App() { }

        public App( XmlNode n ) {
            this.Name = Helper.GNTBN( n, "name" );
            this.IconPath = Helper.GNTBN( n, "icon" );
            this.Installed = bool.Parse( Helper.GNTBN( n, "installed" ) );
            this.Path = Helper.GNTBN( n, "path" );
            this.Extensions =
                Helper.GNBN( n, "extensions" )
                    .ChildNodes.OfType<XmlNode>()
                    .Where( a => a.Name == "ext" )
                    .Select( a => a.InnerText )
                    .ToArray();

        }
    }

    public class Category {
        public string Name { get; set; }
        public App[] Apps { get; set; }
        public Category() {}

        public Category( XmlNode n ) {
            this.Name = n.Attributes[ "name" ].Value;
            this.Apps = n.ChildNodes.OfType<XmlNode>().Select( a => new App( a ) ).ToArray();
        }
    }
}
