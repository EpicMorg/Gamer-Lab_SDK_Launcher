using System;
using System.IO;
using glSDK.Configs;

namespace glSDK.WRAPPER
{
    internal class CoreHandler
    {
        #region Singleton
        private static readonly Lazy<CoreHandler> InstanceLazy = new Lazy<CoreHandler>(() => new CoreHandler());

        public static CoreHandler Instance => InstanceLazy.Value;
        #endregion
        //private const string ServersName = "servers.xml";
        //private const string ConfigName = "config.xml";
        //private readonly string _configPath;

        private CoreHandler()
        {
     
        }

        public Config Config { get; set; }


       // public void SaveConfig() { Config.Save(_configPath); }
    }
}
