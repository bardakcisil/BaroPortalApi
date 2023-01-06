

using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.Educations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuyuruController : ControllerBase
    {
        private IDuyuruService _DuyuruService;

        public DuyuruController(IDuyuruService DuyuruService)
        {
            _DuyuruService = DuyuruService;
        }
        [HttpGet("getall")]
        public ActionResult ShowDuyurular()
        {

            var result = _DuyuruService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddBildirim(UploadDto Duyurular)
        {
            var result = _DuyuruService.Add(Duyurular);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Duyurular did not added"); }


        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _DuyuruService.DeleteAd(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
