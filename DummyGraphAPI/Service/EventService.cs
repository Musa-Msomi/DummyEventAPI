using AutoMapper;
using DummyGraphAPI.Models;

namespace DummyGraphAPI.Service
{
    public class EventService : IEventService
    {
        GraphAPIClientService _graphAPIClientService;
        private readonly IMapper _mapper;

        public EventService(GraphAPIClientService graphAPIClientService, IMapper mapper)
        {
            _graphAPIClientService = graphAPIClientService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventsDTO>> GetAllEventsViaDTO()
        {
            var eventsFromGraphAPI = await _graphAPIClientService.GetUpcomingEvents();

            var eventsToReturn = _mapper.Map<IEnumerable<EventsDTO>>(eventsFromGraphAPI);

            return eventsToReturn;
        }
    }
}
