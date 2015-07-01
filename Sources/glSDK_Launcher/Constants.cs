using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace glSDK
{
    public static class Constants {
        public static readonly string CompilersPath = @"..\..\XML\Compilers.xml";
        public static readonly string AppsPath = @"..\..\XML\list.xml";

        public static readonly string CurrentPath = Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location );
        public static readonly string RootPath = Path.GetDirectoryName(CurrentPath);
        public static readonly string SettingsPath = Path.Combine( CurrentPath, "Settings.xml" );
    }
}
