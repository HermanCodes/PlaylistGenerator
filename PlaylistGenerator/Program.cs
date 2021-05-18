using CommandLine;
using GenerationLibrary;
using ReportLibrary;
using System.Diagnostics;

namespace PlaylistGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            Options options = new Options();
            Report report = new Report();

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o => options = o);

            XmlGenerator.GeneratePlaylistFile(report.GetTests(options.ProjectName, options.FileInput, options.Target), options.FileOutput);
        }
    }
}
