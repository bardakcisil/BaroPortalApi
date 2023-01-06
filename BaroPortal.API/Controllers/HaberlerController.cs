
using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.ListDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HaberlerController : ControllerBase
    {
        private IHaberlerService _HaberlerService;

        public HaberlerController(IHaberlerService HaberlerService)
        {
            _HaberlerService = HaberlerService;
        }
        [HttpGet("getall")]
        public ActionResult ShowHaberler()
        {

            var result = _HaberlerService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddHaber(AddDto Haberler)
        {
            var result = _HaberlerService.Add(Haberler);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Haberler did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _HaberlerService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
