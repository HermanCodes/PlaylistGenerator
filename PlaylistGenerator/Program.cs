using GenerationLibrary;

namespace PlaylistGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlGenerator.GeneratePlaylistFile(LocateFailedTests.GetTests("BookShop.AcceptanceTests"));
        }
    }
}
