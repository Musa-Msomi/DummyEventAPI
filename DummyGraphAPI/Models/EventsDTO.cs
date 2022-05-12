﻿namespace DummyGraphAPI.Models
{
    using System.Collections.Generic;
    using DummyGraphAPI.Models.UpcomingEvents;
    using Newtonsoft.Json;

    public abstract class EventsDTO
    {


        [JsonProperty("subject")]
        public string? Subject { get; set; }

        [JsonProperty("bodyPreview")]
        public string? BodyPreview { get; set; }

        //[JsonProperty("responseStatus")]
        //public Status? ResponseStatus { get; set; }

        //[JsonProperty("body")]
        //public BodyDTO? Body { get; set; }

        [JsonProperty("start")]
        public StartDTO? Start { get; set; }

        [JsonProperty("end")]
        public EndDTO? End { get; set; }

        [JsonProperty("location")]
        public LocationDTO? Location { get; set; }

        //[JsonProperty("attendees")]
        //public List<Attendee>? Attendees { get; set; }

        [JsonProperty("organizer")]
        public OrganizerDTO? Organizer { get; set; }
    }
}


