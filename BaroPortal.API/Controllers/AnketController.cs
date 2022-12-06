using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnketController : ControllerBase
    {
        private IAnketService _AnketService;

        public AnketController(IAnketService AnketService)
        {
            _AnketService = AnketService;
        }
        [HttpGet("getall")]
        public ActionResult ShowAnket()
        {

            var result = _AnketService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddAnket(AnketDto Anket)
        {
            var result = _AnketService.Add(Anket);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Anket did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _AnketService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
