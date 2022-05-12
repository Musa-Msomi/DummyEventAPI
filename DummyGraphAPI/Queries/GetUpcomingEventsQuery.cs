using DummyGraphAPI.Models;
using MediatR;

namespace DummyGraphAPI.Queries
{
    public class GetUpcomingEventsQuery : IRequest<IEnumerable<EventsDTO>>
    {
    }
}
