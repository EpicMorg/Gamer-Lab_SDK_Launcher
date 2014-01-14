using System;
using System.IO;
using System.Reflection;

namespace gSDK_Launcher {
    internal class AssemblyInfoHelper {
        public static string GetPath( string path ) {
            return Path.Combine( Path.GetDirectoryName( Path.GetDirectoryName( CurrentAssembly.Location ) ), path );
        }
        private static Lazy<Assembly> _currentAssembly = new Lazy<Assembly>(()=> Assembly.GetAssembly( typeof(AssemblyInfoHelper)) );
        public static Assembly CurrentAssembly {
            get {
                return _currentAssembly.Value;
            }
        }

        public static T GetAttribute<T>() where T : class {
            var attr = CurrentAssembly.GetCustomAttributes( typeof( T ), false );
            return attr.Length > 0 ? attr[ 0 ] as T : null;
        }

        private static Lazy<Assembly> vguinfo = new Lazy<Assembly>(
            () => Assembly.LoadFile(
                Path.Combine(  Path.GetDirectoryName( CurrentAssembly.Location ) ,"gSDK_vgui.dll" )
            )
        );
        public static Assembly VGuinfo {
            get { return vguinfo.Value; }
        }
    }
}
