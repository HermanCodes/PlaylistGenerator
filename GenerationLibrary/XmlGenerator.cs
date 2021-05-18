using System.Collections.Generic;
using System.Xml;

namespace ReportLibrary
{
    public class XmlGenerator
    {
        public static void GeneratePlaylistFile(List<string> failedTestNames, string outputPath)
        {
            using var xmlWriter = new XmlTextWriter(outputPath, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartElement("Playlist");
            xmlWriter.WriteAttributeString("Version", "1.0");

            foreach (var test in failedTestNames)
            {
                xmlWriter.WriteStartElement("Add");
                xmlWriter.WriteAttributeString("Test", test);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }
}
