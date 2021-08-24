using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Games.Common.Extensions
{
    public static class XMLExstensions
    {
        public static string GetXMLRootFromObject(this object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = new XmlTextWriter(sw);
            string xmlOutPut = "";
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
                tw.Close();
            }

            xmlOutPut = Regex.Replace(sw.ToString(), "encoding=\"utf-16\"?", "");

            xmlOutPut = ChangeNodeToRoot(LowerCaseTags(xmlOutPut), o.GetType().Name);
            return xmlOutPut;
        }

        public static string ChangeNodeToRoot(this string xmlString, string mainNode)
        {
            mainNode = mainNode.ToLower();
            xmlString = xmlString.Replace("<" + mainNode, "<root").Replace("</" + mainNode + ">", "</root>");
            xmlString = xmlString.Replace(@" xsi:nil=""true""", "");
            xmlString = xmlString.Replace(">true<", ">1<").Replace(">false<", ">0<");
            return xmlString;
        }
        /// <summary>
        /// Will Convert all XML tags to Lower Case
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string LowerCaseTags(this string xml)
        {
            return Regex.Replace(
                xml,
                @"<[^<>]+>",
                m => { return m.Value.ToLower(); },
                RegexOptions.Multiline | RegexOptions.Singleline);
        }
    }
}
