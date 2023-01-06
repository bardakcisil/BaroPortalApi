
using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoruController : ControllerBase
    {
        private ISoruService _soruService;

        public SoruController(ISoruService soruService)
        {
            _soruService = soruService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _soruService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddSoru(SoruDto addsoru)
        {
            var result = _soruService.Add(addsoru);
            if (result is not null)
            {
                return Ok(result);
            }
            else { return BadRequest("Soru is not added"); }


        }

        [HttpPost("addAnswer")]
       public ActionResult UpdateAnswer(AnketAnswerDto anketAnswerDto)
        {
            
            var result = _soruService.UpdateAnswer(anketAnswerDto);

           
                return Ok(result);
           




        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _soruService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetBySurveyId(int? id)
        {

            var result = _soruService.GetBySurveyId(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
