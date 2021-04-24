using Newtonsoft.Json;

namespace JSONUtils
{
    public class Match
    {

        [JsonProperty("location")]
        public string Location { get; set; }
    }

}