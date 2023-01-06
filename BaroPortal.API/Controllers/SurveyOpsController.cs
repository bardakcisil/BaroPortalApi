
using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyOpsController : ControllerBase
    {
        private ISurveyOpsService _SurveyOpsService;

        public SurveyOpsController(ISurveyOpsService SurveyOpsService)
        {
            _SurveyOpsService = SurveyOpsService;
        }
        [HttpGet("getall")]
        public ActionResult ShowSurveyOps()
        {

            var result = _SurveyOpsService.GetList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult AddSurveyOps(SurveyOpsDto SurveyOps)
        {
            var result = _SurveyOpsService.Add(SurveyOps);
            if (result is not null)
            {
                return Ok(result);
            }
            else { return BadRequest("SurveyOps did not added"); }


        }
        [HttpPost("addAnswer")]
        public ActionResult AddAnswer(AddSurveyOpsDto surveyOpsDto)
        {

            var result = _SurveyOpsService.AddAnswer(surveyOpsDto);


            return Ok(result);





        }

    }
}
