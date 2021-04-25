using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ReportLibrary
{
    public class XmlGenerator
    {
        public static void GeneratePlaylistFile(List<string> failedTestNames)
        {
            var fileName = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "FailedTests.Playlist");
            using var xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
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
