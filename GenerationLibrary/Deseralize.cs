using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ReportLibrary
{
    public class Deseralize<T>
    {
        public List<T> ReadJson(string filePath) => JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
    }
}
