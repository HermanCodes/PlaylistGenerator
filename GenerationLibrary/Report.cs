using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ReportLibrary
{
    public class Report
    {
        public const string FullyQualifiedName = "{0}.{1}.#()::TestAssembly:{2}/Feature:{3}/Scenario:{4}";
        public const string FullyQualifiedNameWithTarget = "{0}.{1}.#()::Target:{2}/TestAssembly:{3}/Feature:{4}/Scenario:{5}";

        public List<string> GetTests(string projectName)
        {
            var failedTestNames = new List<string>();

            var reports = DeseralizeJson.ReadReports(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Report.json"));

            reports.SelectMany(report => report.Elements)
                   .SelectMany(step => step.Steps)
                   .Where(step => step.Result.Status == "Failed");
            {
                for (int i = 0; i < reports[0].Elements.Count(); i++)
                    failedTestNames.Add(GetFullyQualifiedName(projectName, reports[0].Name, reports[0].Elements[i].Name, "Integrated"));
            }

            return failedTestNames;
        }

        public string GetFullyQualifiedName(string project, string feature, string scenario, string target = "")
        {
            if (target != null)
            {
                return string.Format(FullyQualifiedNameWithTarget, project, feature, target, project, HttpUtility.UrlEncode(feature), HttpUtility.UrlEncode(scenario));
            }
            return string.Format(FullyQualifiedName, project, feature, project, HttpUtility.UrlEncode(feature), HttpUtility.UrlEncode(scenario));
        }
    }
}
