using DummyGraphAPI.Models;

namespace DummyGraphAPI.Service
{
    public interface IEventService
    {
        Task<IEnumerable<EventsDTO>> GetAllEventsViaDTO();
    }
}
