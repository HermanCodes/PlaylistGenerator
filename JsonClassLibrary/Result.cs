using Newtonsoft.Json;

namespace JSONUtils
{
    public class Result
    {

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("error_message")]
        public object ErrorMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

}