using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.OtherApps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UygulamalarimizController : ControllerBase
    {
        private IUygulamalarimizService _UygulamalarimizService;

        public UygulamalarimizController(IUygulamalarimizService UygulamalarimizService)
        {
            _UygulamalarimizService = UygulamalarimizService;
        }
        [HttpGet("getall")]
        public ActionResult ShowUygulamalarimiz()
        {

            var result = _UygulamalarimizService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddBildirim(AppDto Uygulamalarimiz)
        {
            var result = _UygulamalarimizService.Add(Uygulamalarimiz);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Uygulamalarimiz did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _UygulamalarimizService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
