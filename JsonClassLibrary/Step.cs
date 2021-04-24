using Newtonsoft.Json;

namespace JSONUtils
{
    public class Step
    {

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }

        [JsonProperty("match")]
        public Match Match { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

}