using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        [HttpGet("getall")]
        public ActionResult ShowAnnouncement()
        {

            var result = _announcementService.ShowList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddAnnouncement(AddAnnouncementDto announcement)
        {
            var result = _announcementService.Add(announcement);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Announcement did not added"); }


        }
    }
}
