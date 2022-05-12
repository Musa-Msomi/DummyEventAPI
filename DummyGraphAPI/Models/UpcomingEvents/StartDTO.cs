using Newtonsoft.Json;

namespace DummyGraphAPI.Models.UpcomingEvents
{
    public class StartDTO
    {
        [JsonProperty("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }
}
