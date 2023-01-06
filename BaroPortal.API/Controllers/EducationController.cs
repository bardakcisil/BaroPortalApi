using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.Educations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BaroPortal.Entities.Dto.Educations.AddEducationDto;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private IEducationService _educationService;
    

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }
        [HttpGet("getall")]
        public ActionResult ShowEducation()
        {

            var result = _educationService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public  IActionResult GetPdf(int id)
        {

            var result = _educationService.GetPdf(id);


            //string file = Convert.ToBase64String(result.PdfFile);
            //byte[] bytes = Convert.FromBase64String(file);
            //MemoryStream streamx = new MemoryStream(bytes);
            

            if (result is not null)
            {
                var stream = new FileStream(result.FilePath, FileMode.Open, FileAccess.Read);
                return File(stream, "application/pdf", result.FileName);

                //return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _educationService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addFile")]
        public ActionResult Add([FromForm] AddEducationDto addEducations)
        {
  
            var result = _educationService.Add(addEducations);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("Educations did not added"); }


        }
    }
}
