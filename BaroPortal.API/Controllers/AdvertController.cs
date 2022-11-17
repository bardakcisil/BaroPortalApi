using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private IAdvertService _advertService;

        public AdvertController(IAdvertService advertService)
        {
            _advertService = advertService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _advertService.GetAll();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddAdvert(AddAdvertDto addAdvert)
        {
            var result = _advertService.AddAdvert(addAdvert);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Advert is not added"); }


        }

        [HttpGet("Delete Ad/{{id}}")]
        public bool DeleteDecree(int id)
        {
            _advertService.DeleteAd(id);
            return true;
        }
        //    [HttpDelete("{id}")]
        //public async Task<ActionResult<List<Advert>>> DeleteHero(int id)
        //{
        //    var result = await _superHeroService.DeleteHero(id);
        //    if (result is null)
        //        return NotFound("Hero not found.");

        //    return Ok(result);
        //}

    }
}
