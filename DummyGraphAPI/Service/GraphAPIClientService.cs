using DummyGraphAPI.Helpers;
using Microsoft.Graph;
using System.Net.Http.Headers;

namespace DummyGraphAPI.Service
{
    public class GraphAPIClientService
    {
        private readonly IHelper _helper;

        public GraphAPIClientService(IHelper helper)
        {
            _helper = helper;
        }

        public async Task<IEnumerable<Event>> GetUpcomingEvents()
        {
            var token = _helper.GetAccessToken();

            GraphServiceClient graphClient = new GraphServiceClient(new DelegateAuthenticationProvider(provider =>
            {
                provider.Headers.Authorization = new AuthenticationHeaderValue("Bearer",token);

                return Task.FromResult(0);

            }));
            var startOfWeek = DateTime.Now;
            var endOfWeek = startOfWeek.AddDays(2);

            var viewOptions = new List<QueryOption>
            {
                new QueryOption("startDateTime", startOfWeek.ToString("o")),
                new QueryOption("endDateTime", endOfWeek.ToString("o"))
            };

            var myEvents = await graphClient.Me.CalendarView
                .Request(viewOptions)
                .Header("Prefer", "outlook.timezone=\"South Africa Standard Time\"")
                .GetAsync();

            var testing = myEvents.AsEnumerable();

            // var eventsToReturn = _mapper.Map<IEnumerable<EventsDTO>>(testing);

            // return eventsToReturn;

            return testing;
        }
    }
}
