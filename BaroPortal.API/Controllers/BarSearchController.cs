using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarSearchController : ControllerBase
    {
        private IBarSearchService _barsearchService;

        public BarSearchController(IBarSearchService barsearchService)
        {
            _barsearchService = barsearchService;
        }
        //[HttpPost("GetLawer")]
        //public ActionResult GetAll(int typeid = 0, string name = null, string surname = null , int snum=0 )
        //{

        //    var result = _barsearchService.GetTypeById(typeid,name,surname,snum);
        //    if (result is not null)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        [HttpPost("GetLawyer")]
        public ActionResult GetAll(BaroSearchDto barsearchDto)
        {

            var result = _barsearchService.CheckUser(barsearchDto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public ActionResult Add(BaroSearchDto barosearchDto)
        {
            var result = _barsearchService.AddLawyer(barosearchDto);
            if (result)
            {
                return Ok(result);
               

            }
            else { return BadRequest("User Not Found"); }


        }
    }
}
