using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BulletinController : ControllerBase
    {
        private IBulletinService _bulletinService;

        public BulletinController(IBulletinService bulletinService)
        {
            _bulletinService = bulletinService;
        }


        [HttpPost("add")]
        public IActionResult Add(AddBulletin bulletin)
        {
            var result = _bulletinService.AddBulletin(bulletin);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Bulletin did not added");

        }
    }
}
