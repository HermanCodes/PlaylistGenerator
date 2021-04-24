using Newtonsoft.Json;

namespace JSONUtils
{
    public class Tag
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }
    }

}