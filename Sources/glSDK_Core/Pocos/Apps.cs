using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace glSDK.Pocos {
    [Serializable]
    public class Apps {
        public List<Category> Categories { get; set; } = new List<Category>();
    }

    [Serializable]
    public class Category {
        [XmlAttribute]
        public string Name { get; set; }

        public List<App> Apps { get; set; } = new List<App>();
    }

    [Serializable]
    public class App {
        public string Name { get; set; }
        public string Path { get; set; }
    }
}