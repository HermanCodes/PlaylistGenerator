using Newtonsoft.Json;

namespace ReportModels
{
    public class MatchModel
    {

        [JsonProperty("location")]
        public string Location { get; set; }
    }

}