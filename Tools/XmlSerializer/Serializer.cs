namespace XmlSerializer
{
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public static class Serializer
    {
        #region PublicMethods

        public static string Serialize<T>(T obj, bool formatted = false, XmlSerializerNamespaces namespaces = null)
        {
            var xmlSerializer = new XmlSerializer(obj.GetType());
            using (var ms = new MemoryStream())
            {
                using (var textWriter = new XmlTextWriter(ms, new UTF8Encoding()))
                {
                    if (formatted)
                    {
                        textWriter.Formatting = Formatting.Indented;
                        textWriter.IndentChar = ' ';
                        textWriter.Indentation = 5;
                    }
                    else
                    {
                        textWriter.Formatting = Formatting.None;
                    }
                    xmlSerializer.Serialize(textWriter, obj, namespaces);
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        public static XmlDocument SerializeToDocXML<T>(T obj)
        {
            var xmlString = Serialize(obj);

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            return doc;
        }

        public static T Deserialize<T>(string xml) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(xml))
            {
                return (T)xmlSerializer.Deserialize(sr);
            }
        }

        #endregion
    }
}
