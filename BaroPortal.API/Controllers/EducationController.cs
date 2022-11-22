using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BaroPortal.Entities.Dto.AddEducationDto;

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

            var result = _educationService.ShowList();
            if (result is not null)
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
