using Newtonsoft.Json;

namespace DummyGraphAPI.Models.UpcomingEvents
{
    public class AttendeeDTO
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("emailAddress")]
        public EmailAddressDTO EmailAddress { get; set; }
    }
}
