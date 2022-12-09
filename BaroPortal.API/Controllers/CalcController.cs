﻿using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BaroPortal.API.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {

        private ICalculationService _calculationService;

        public CalcController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }




        [HttpPost("GetResult")]
        public ActionResult GetAll(CalculationDto calculationDto)
        {

            var result = _calculationService.Calculate(calculationDto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
