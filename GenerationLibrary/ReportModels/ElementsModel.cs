using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReportModels
{
    public class ElementsModel
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public IList<TagsModel> Tags { get; set; }

        [JsonProperty("steps")]
        public IList<StepsModel> Steps { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}