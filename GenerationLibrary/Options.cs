using CommandLine;

namespace GenerationLibrary
{
    public class Options
    {
        [Option('o', "output", Required = true, HelpText = "Full path to output file including file name (file name must end with .playlist)")]
        public string FileOutput { get; set; }

        [Option('i', "input", Required = true, HelpText = "Full path to the test report")]
        public string FileInput { get; set; }

        [Option('p', "projectName", Required = true, HelpText = "Name of project file, do not inlcude .dll")]
        public string ProjectName { get; set; }

        [Option('t', "target", Required = false, HelpText = "If project outputs fully qualified names with a target then you can input the target here and it will be implemented into the playlist")]
        public string Target { get; set; }
    }
}
