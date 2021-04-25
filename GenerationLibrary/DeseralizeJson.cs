using ReportModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ReportLibrary
{
    public class DeseralizeJson
    {
        public static List<RootModel> ReadReports(string filePath) => JsonConvert.DeserializeObject<List<RootModel>>(File.ReadAllText(filePath));
    }
}
