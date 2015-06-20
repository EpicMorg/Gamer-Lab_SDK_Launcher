using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace gSDK_Launcher.Core {
    internal class Helper {
        public static XmlNode Gnbn( XmlNode n, string name ) {
            return n.ChildNodes.OfType<XmlNode>().FirstOrDefault( a => a.Name == name );
        }
        public static string Gntbn( XmlNode n, string name ) {
            var tmp = Gnbn( n, name );
            return tmp?.InnerText ?? "";
        }
        public static RPath GrPath( XmlNode n ) {
            if ( n == null ) throw new ArgumentNullException();
            Debug.Assert(n.Attributes != null, "n.Attributes != null");
            var attr = n.Attributes[ "type" ];
            var v = attr?.InnerText ?? "Relative";
            return new RPath {
                Path = n.InnerText,
                Type = (PathType) Enum.Parse( typeof( PathType ), v )
            };
        }
    }

    public class Config {
        private const string SnlName = "Support and Links";
        private const string CustName = "Custom";

        public Category[] Apps { get; set; }
        public Category Support { get; set; }
        public Category Custom { get; set; }
        public string Lang { get; set; }
        public Config() { }

        public Config( XmlNode n ) {
            Apps =
                n.ChildNodes.OfType<XmlNode>()
                    .First( a => a.Name == "apps" )
                    .ChildNodes.OfType<XmlNode>()
                    .Select( a => new Category( a ) )
                    .ToArray();
            Support = new Category( n.ChildNodes.OfType<XmlNode>().First( a => a.Attributes != null && (a.Name == "category" && a.Attributes[ "name" ] != null && a.Attributes[ "name" ].Value == SnlName) ) );
            Custom = new Category( n.ChildNodes.OfType<XmlNode>().First( a => a.Attributes != null && (a.Name == "category" && a.Attributes[ "name" ] != null && a.Attributes[ "name" ].Value == CustName) ) );
            Lang = n.ChildNodes.OfType<XmlNode>().First( a => a.Name == "lang" ).InnerText;
        }

        public static Config Load( string path ) {
            var d = new XmlDocument();
            d.Load( path );
            return new Config( d.DocumentElement );
        }

        public void Save( string path ) {
            new XDocument(
                new XDeclaration( "1.0", "utf-8", "yes" ),
                new XElement(
                    "cfg",
                    new XElement( "lang", Lang ),
                    new XElement( "apps", SerializeCatList( Apps ) ),
                    new XElement(
                        "category",
                        new XAttribute( "name", SnlName ),
                        Support.Apps.Select( SerializeApp )
                    ),
                    new XElement(
                        "category",
                        new XAttribute( "name", CustName ),
                        Custom.Apps.Select( SerializeApp )
                    )
                )
            ).Save( path );
        }

        private IEnumerable<XElement> SerializeCatList( IEnumerable<Category> cats ) {
            return cats.Select( SerializeCat );
        }

        private static XElement SerializeCat( Category a ) {
            return new XElement( "category", new XAttribute( "name", a.Name ), a.Apps.Select( SerializeApp ) );
        }

        private static XElement SerializeApp( App b ) {
            try {
                return new XElement(
                    "app",
                    new XElement( "name", b.Name ),
                    new XElement( "icon", new XAttribute( "type", b.IconPath.Type ), b.IconPath.Path ),
                    new XElement( "path", new XAttribute( "type", b.Path.Type ), b.Path.Path ),
                    new XElement( "installed", b.Installed ),
                    new XElement( "extensions", b.Extensions.Select( c => new XElement( "ext", c ) ) ),
                    new XElement( "cmdargs", b.Params ) );
            }
            catch ( Exception ex ) {
                Console.WriteLine(ex); //dev>>null
                throw;
            }
        }
    }

    public class App {
        public string Name { get; set; }
        public RPath IconPath { get; set; }
        public RPath Path { get; set; }
        public string Params { get; set; }
        public string[] Extensions { get; set; }
        public bool Installed { get; set; }

        public override string ToString() {
            return Name;
        }

        public App() { }
        public App( XmlNode n ) {
            XmlNode tmpn;
            Func<string, RPath> gn = s => ( tmpn = Helper.Gnbn( n, s ) ) != null ? Helper.GrPath( tmpn ) : new RPath {
                Type = PathType.Relative,
                Path = ""
            };
            Name = Helper.Gntbn( n, "name" );
            IconPath = gn( "icon" );
            var tmps = Helper.Gntbn( n, "installed" );
            Installed = !String.IsNullOrEmpty( tmps ) && bool.Parse( tmps );
            Path = gn( "path" );
            var tmp = Helper.Gnbn( n, "extensions" );
            Extensions = tmp?.ChildNodes.OfType<XmlNode>()
                .Where( a => a.Name == "ext" )
                .Select( a => a.InnerText )
                .ToArray() ?? new string[] { };
            Params = Helper.Gntbn( n, "cmdargs" );
        }
    }

    public class Category {
        public string Name { get; set; }
        public App[] Apps { get; set; }
        public Category() { }

        public Category( XmlNode n ) {
            try
            {
                if (n.Attributes != null) Name = n.Attributes[ "name" ].Value;
                Apps = n.ChildNodes.OfType<XmlNode>().Select( a => new App( a ) ).ToArray();
            }
            catch {

            }
        }
    }

    public class RPath {
        public PathType Type { get; set; }
        public string Path { get; set; }

        public override string ToString() {
            return Type == PathType.Absolute ? Path : AssemblyInfoHelper.GetPath( Path );
        }
    }

    public enum PathType {
        Absolute,
        Relative
    }
}
/*
 * Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn.
 */