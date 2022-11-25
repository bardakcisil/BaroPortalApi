﻿using BaroPortal.Business.Abstract;
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
        [HttpGet("getall{typeid}")]
        public ActionResult GetAll(int typeid, string name=null, string surname = null, int snum = 0)
        {

            var result = _barsearchService.GetTypeById(typeid,name,surname,snum);
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
            else { return BadRequest("Event did not added"); }


        }
    }
}
