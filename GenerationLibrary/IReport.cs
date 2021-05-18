using System.Collections.Generic;

namespace ReportLibrary
{
    public interface IReport
    {
        string GetFullyQualifiedName(string project, string feature, string scenario, string target = "");
        List<string> GetTests(string projectName, string reportPath, string target);
    }
}