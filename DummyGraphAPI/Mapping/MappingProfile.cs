using AutoMapper;
using DummyGraphAPI.Models;
using DummyGraphAPI.Models.UpcomingEvents;
using Microsoft.Graph;


namespace DummyGraphAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Event, EventsDTO>();
            CreateMap<Microsoft.Graph.Location, LocationDTO>();
            CreateMap<Microsoft.Graph.EmailAddress, EmailAddressDTO>();
            CreateMap<Microsoft.Graph.Recipient, OrganizerDTO>();
            CreateMap<Microsoft.Graph.DateTimeTimeZone, StartDTO>();
            CreateMap<Microsoft.Graph.DateTimeTimeZone, EndDTO>();
            CreateMap<ItemBody, BodyDTO>();
        }
    }
}
