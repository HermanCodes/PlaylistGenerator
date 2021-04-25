using Newtonsoft.Json;

namespace ReportModels
{
    public class ResultsModel
    {

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("error_message")]
        public object ErrorMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

}