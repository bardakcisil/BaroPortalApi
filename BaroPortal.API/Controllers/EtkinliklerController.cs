using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.ListDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtkinliklerController : ControllerBase
    {
        private IEtkinliklerService _EtkinliklerService;

        public EtkinliklerController(IEtkinliklerService EtkinliklerService)
        {
            _EtkinliklerService = EtkinliklerService;
        }
        [HttpGet("getall")]
        public ActionResult ShowEtkinlikler()
        {

            var result = _EtkinliklerService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddEtkinlik(AddDto Etkinlikler)
        {
            var result = _EtkinliklerService.Add(Etkinlikler);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Etkinlikler did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _EtkinliklerService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
