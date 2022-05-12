using DummyGraphAPI.Models;
using Microsoft.Graph;

namespace DummyGraphAPI
{
    public interface IGraphClient
    {
        Task <IEnumerable<Event>> GetAllEvents();
        Task<IEnumerable<EventsDTO>> GetAllEventsViaDTO();
    }
}
