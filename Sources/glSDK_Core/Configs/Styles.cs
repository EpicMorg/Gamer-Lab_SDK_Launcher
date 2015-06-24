using System.Xml.Serialization;
using MetroFramework;

namespace glSDK.Configs
{
    public class Style
    {
        public Style() { }

        public Style(MetroColorStyle style = MetroColorStyle.Silver)
        {
            StyleCode = style;
        }
        [XmlAttribute]
        public MetroColorStyle StyleCode
        {
            get;
            set;
        }
        public override string ToString() => StyleCode.ToString();
    }
}
