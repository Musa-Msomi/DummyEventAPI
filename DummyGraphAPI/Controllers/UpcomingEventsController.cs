using DummyGraphAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DummyGraphAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpcomingEventsController : ControllerBase
    {
        //private readonly IGraphClient _graphClient;
        private readonly IMediator _mediator;

        public UpcomingEventsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetUpcomingEvents()
        {
            var query = new GetUpcomingEventsQuery();

            var upcomingEventsToReturn = await _mediator.Send(query);

            return Ok(upcomingEventsToReturn);
        }

        //public UpcomingEventsController(IGraphClient graphClient)
        //{
        //    _graphClient = graphClient;
        //}

        //[HttpGet()]
        //public async Task<IActionResult> GetEvents()
        //{
        //    var events = await _graphClient.GetAllEvents();

        //    return Ok(events);
        //}

        //[HttpGet("GetEventsDTO")]
        //public async Task<IActionResult> GetEventsDTO()
        //{
        //    var events = await _graphClient.GetAllEventsViaDTO();

        //    return Ok(events);
        //}




    }
}
