using DummyGraphAPI.Models;
using DummyGraphAPI.Service;
using MediatR;

namespace DummyGraphAPI.Queries
{
    public class GetUpcomingEventsQueryHandler : IRequestHandler<GetUpcomingEventsQuery, IEnumerable<EventsDTO>>
    {
        private readonly IEventService _eventService;

        public GetUpcomingEventsQueryHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public Task<IEnumerable<EventsDTO>> Handle(GetUpcomingEventsQuery request, CancellationToken cancellationToken)
        {
            var upcomingEvents = _eventService.GetAllEventsViaDTO();

            return upcomingEvents;
        }
    }
}
