using ReportLibrary;

namespace PlaylistGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();

            XmlGenerator.GeneratePlaylistFile(report.GetTests("BookShop.AcceptanceTests"));
        }
    }
}
