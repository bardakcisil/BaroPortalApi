using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private INewService _newService;

        public NewController(INewService newService)
        {
            _newService = newService;
        }
        [HttpGet("getall")]
        public ActionResult ShowNew()
        {

            var result = _newService.ShowList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult Add(AddNewDto addNews)
        {
            var result = _newService.Add(addNews);
            if (result)
            {
                return Ok(result);
            }
            else { return BadRequest("New did not added"); }


        }
    }
}
