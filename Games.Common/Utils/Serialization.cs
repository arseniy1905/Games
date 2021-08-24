using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Games.Common.Utils
{
    public static class Serialization
    {
        public static string XmlSerializeToString(this object objectInstance)
        {
            if (objectInstance != null)
            {
                var serializer = new XmlSerializer(objectInstance.GetType());
                var sb = new StringBuilder();

                using (TextWriter writer = new StringWriter(sb))
                {
                    serializer.Serialize(writer, objectInstance);
                }
                return sb.ToString();
            }
            return string.Empty;
        }
    }
}
