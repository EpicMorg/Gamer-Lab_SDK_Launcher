﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gSDK_Launcher.UI {
    public class AbyrvalgTranslator {
        public string Culture { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        private Dictionary<string, string> _translation { get; set; }

        public static AbyrvalgTranslator Load( string path ) {
            var doc = XDocument.Load( path );
            var meta = doc.Root.Descendants( "metadata" ).First();
            return new AbyrvalgTranslator() {
                Culture = meta.Descendants( "culture" ).First().Value,
                Author = meta.Descendants( "author" ).First().Value,
                Version = meta.Descendants( "version" ).First().Value,
                _translation = doc
                    .Descendants( "translation" )
                    .First()
                    .Descendants( "term" )
                    .ToDictionary(
                        a => a.Attribute( "name" ).Value,
                        a => a.Value
                    )
            };
        }

        public void Translate( IEnumerable<Control> controls, string parent ) {
            if ( this._translation == null ) return;
            foreach ( var control in controls ) {
                string s;
                if ( this._translation.TryGetValue( parent + "." + control.Name, out s ) )
                    control.Text = s;
                this.Translate( control.Controls.OfType<Control>(), parent );
            }
        }
    }
}
