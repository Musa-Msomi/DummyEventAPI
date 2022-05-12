using Newtonsoft.Json;

namespace DummyGraphAPI.Models.UpcomingEvents
{
    public class OrganizerDTO
    {
        [JsonProperty("emailAddress")]
        public EmailAddressDTO EmailAddress { get; set; }
    }
}
