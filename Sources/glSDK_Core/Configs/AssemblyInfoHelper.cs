using System;
using System.Reflection;
using static System.IO.Path;

namespace glSDK.Configs {
    internal class AssemblyInfoHelper {
        public static string GetPath( string path ) {
            return Combine( GetDirectoryName( GetDirectoryName( CurrentAssembly.Location ) ), path );
        }
        private static Lazy<Assembly> _currentAssembly = new Lazy<Assembly>(()=> Assembly.GetAssembly( typeof(AssemblyInfoHelper)) );
        public static Assembly CurrentAssembly => _currentAssembly.Value;

        public static T GetAttribute<T>() where T : class {
            var attr = CurrentAssembly.GetCustomAttributes( typeof( T ), false );
            return attr.Length > 0 ? attr[ 0 ] as T : null;
        }

        private static readonly Lazy<Assembly> Vguinfo = new Lazy<Assembly>(
            () => Assembly.LoadFile(
                Combine(  GetDirectoryName( CurrentAssembly.Location ) ,"glSDK_Core.dll" )
            )
        );
        public static Assembly VGuinfo => Vguinfo.Value;
    }
}
