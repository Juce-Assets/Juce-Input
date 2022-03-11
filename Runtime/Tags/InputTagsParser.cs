using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Juce.Input.Tags
{
    public static class InputTagsParser
    {
        public static List<XmlNode> Parse(string text)
        {
            List<XmlNode> nodes = new List<XmlNode>();

            List<string> xmlPortions = FindXmlPortions(text);

            foreach (string portion in xmlPortions)
            {
                XmlDocument xmlDocument = new XmlDocument();

                try
                {
                    xmlDocument.Load(new StringReader(portion));
                }
                catch
                {
                    continue;
                }

                XmlNodeList nodeList = xmlDocument.SelectNodes("input");

                foreach(XmlNode node in nodeList)
                {
                    nodes.Add(node);
                }
            }

            return nodes;
        }

        public static string ReplaceTag(string text, string tagContent, string replacement)
        {
            string fullTag = string.Format("<input>{0}</input>", tagContent);

            return text.Replace(fullTag, replacement);
        }

        public static List<string> FindXmlPortions(string text)
        {
            List<string> portions = new List<string>();

            MatchCollection matchCollection = Regex.Matches(text, @"<([^>]+)>[^<]*</(\1)>");

            foreach (Match match in matchCollection)
            {
                portions.Add(match.Value);
            }

            return portions;
        }
    }
}
