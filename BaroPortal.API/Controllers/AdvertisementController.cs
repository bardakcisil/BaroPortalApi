using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto.Advertisement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private IAdvertisementService _advertService;

        public AdvertisementController(IAdvertisementService advertService)
        {
            _advertService = advertService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _advertService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddAdvertisement(AddAdvertisementDto addAdvert)
        {
            var result = _advertService.AddAdvertisement(addAdvert);
            if (result is not null)
            {
                return Ok(result);
            }
            else { return BadRequest("Advert is not added"); }


        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _advertService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetByCategoryId(int id)
        {

            var result = _advertService.GetByTypeId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
