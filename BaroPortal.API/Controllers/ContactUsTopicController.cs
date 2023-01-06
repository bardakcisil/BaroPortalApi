
using BaroPortal.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsTopicController : ControllerBase
    {
        private IContactUsTopicService _contactUsTopicService;
        // private AppDbContext _dbContext;

        public ContactUsTopicController(IContactUsTopicService contactUsTopicService)//AppDbContext dbContext, )
        {

            // _dbContext = dbContext;
            _contactUsTopicService = contactUsTopicService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _contactUsTopicService.ShowList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
