using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GenerationLibrary
{
    public class LocateFailedTests
    {
        public static List<string> GetTests(string projectName)
        {
            var failedTestNames = new List<string>();
            FQN fQN = new FQN();

            var reports = DeseralizeJson.ReadReports(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Report.json"));

            foreach (var report in reports
                          .SelectMany(element => element.Elements)
                          .SelectMany(step => step.Steps)
                          .Where(step => step.Result.Status == "Failed"))
            {
                for (int i = 0; i < reports[0].Elements.Count(); i++)
                    failedTestNames.Add(fQN.GetFullyQualifiedName(projectName, reports[0].Name, reports[0].Elements[i].Name, "Integrated"));
            }

            return failedTestNames;
        }
    }
}
