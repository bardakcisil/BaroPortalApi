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
        public ActionResult AddBulletin(AddBulletinDto bulletin)
        {
            var result = _bulletinService.AddBulletin(bulletin);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Bulletin did not added"); }

            

        }
    }
}
