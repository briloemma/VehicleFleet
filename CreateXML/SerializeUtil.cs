using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CreateXML
{
    public static class SerializeUtil
    {
        public static void Serialize<T>(string fileName, List<T> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, list);
            }
        }
        public static void SerializeAndAppend<T>(string fileName, List<T> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            {
                serializer.Serialize(fs, list);
            }
        }
    }
}
