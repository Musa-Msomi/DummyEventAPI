using Newtonsoft.Json;

namespace DummyGraphAPI.Models.UpcomingEvents
{
    public class BodyDTO
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
