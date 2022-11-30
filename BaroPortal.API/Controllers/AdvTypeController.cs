using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvTypeController : ControllerBase
    {
        private IAdvTypeService _advertService;
       // private AppDbContext _dbContext;

        public AdvTypeController(IAdvTypeService advertService)//AppDbContext dbContext, )
        {

           // _dbContext = dbContext;
            _advertService = advertService; 
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _advertService.ShowList();   
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
