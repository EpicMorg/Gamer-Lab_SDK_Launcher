using System;
using MetroFramework;

namespace glSDK.Pocos {
    [Serializable]
    public class Settings {
        public string Language { get; set; }
        public MetroThemeStyle Theme { get; set; } = MetroThemeStyle.Default;
    }
}