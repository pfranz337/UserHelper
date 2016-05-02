using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UserHelper
{
    static class Util
    {
        public static string ToXML<T>(this T obj)
        {
            var xml = "";
            XmlSerializer xsSubmit = new XmlSerializer(typeof(T));

            using (StringWriter sww = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(sww))
            {
                xsSubmit.Serialize(writer, obj);
                xml = sww.ToString();
            }
            return xml;

        }

        public static void SaveToXmlFile<T>(this T obj, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(file))
            {
                serializer.Serialize(writer, obj);
            }
        }

    }

}
