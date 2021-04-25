using Newtonsoft.Json;

namespace ReportModels
{
    public class StepsModel
    {

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }

        [JsonProperty("match")]
        public MatchModel Match { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("result")]
        public ResultsModel Result { get; set; }
    }

}