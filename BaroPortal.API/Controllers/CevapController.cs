using BaroPortal.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CevapController : ControllerBase
    {
        private ICevapService _cevapService;
        // private AppDbContext _dbContext;

        public CevapController(ICevapService cevapService)//AppDbContext dbContext, )
        {

            // _dbContext = dbContext;
            _cevapService = cevapService;
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {

            var result = _cevapService.ShowList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
