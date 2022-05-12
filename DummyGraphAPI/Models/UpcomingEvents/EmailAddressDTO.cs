using Newtonsoft.Json;

namespace DummyGraphAPI.Models.UpcomingEvents
{
    public class EmailAddressDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
