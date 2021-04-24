using Newtonsoft.Json;
using System.Collections.Generic;

namespace JSONUtils
{
    public class ReportJson
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("elements")]
        public IList<Element> Elements { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }

        [JsonProperty("tags")]
        public IList<Tag> Tags { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

}