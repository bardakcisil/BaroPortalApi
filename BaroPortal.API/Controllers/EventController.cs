using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IEventsService _eventService;

        public EventController(IEventsService eventService)
        {
            _eventService = eventService;
        }
        [HttpGet("getall")]
        public ActionResult ShowEvent()
        {

            var result = _eventService.ShowList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult Add(AddEventDto addEvents)
        {
            var result = _eventService.Add(addEvents);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Event did not added"); }


        }
    }
}
