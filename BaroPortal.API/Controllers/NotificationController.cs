using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet("getall")]
        public ActionResult ShowNotification()
        {
 
            var result = _notificationService.ShowList();
            if (result is not null)
            {
                return Ok(result); 
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddBulletin(AddNotificationDto notification)
        {
            var result = _notificationService.Add(notification);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Notification did not added"); }


        }
    }
}
