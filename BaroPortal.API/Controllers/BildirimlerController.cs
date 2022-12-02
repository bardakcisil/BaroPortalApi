using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BildirimlerController : ControllerBase
    {
        private IBildirimlerService _BildirimlerService;

        public BildirimlerController(IBildirimlerService BildirimlerService)
        {
            _BildirimlerService = BildirimlerService;
        }
        [HttpGet("getall")]
        public ActionResult ShowBildirimler()
        {

            var result = _BildirimlerService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddBildirim(AddDto Bildirimler)
        {
            var result = _BildirimlerService.Add(Bildirimler);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Bildirimler did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _BildirimlerService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
