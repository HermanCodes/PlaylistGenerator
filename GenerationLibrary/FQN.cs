using System.Web;

namespace GenerationLibrary
{
    class FQN
    {
        public const string FullyQualifiedName = "{0}.{1}.#()::TestAssembly:{2}/Feature:{3}/Scenario:{4}";
        public const string FullyQualifiedNameWithTarget = "{0}.{1}.#()::Target:{2}/TestAssembly:{3}/Feature:{4}/Scenario:{5}";

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