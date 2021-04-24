using JSONUtils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GenerationLibrary
{
    public class DeseralizeJson
    {
        public static List<ReportJson> ReadReports(string filePath) => JsonConvert.DeserializeObject<List<ReportJson>>(File.ReadAllText(filePath));
    }
}
