using Newtonsoft.Json;

namespace ReportModels
{
    public class TagsModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }
    }

}