using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Calculation;
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

            var result = _calculationService.LivingFeeCalculate(calculationDto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("GetAttorney")]
        public ActionResult GetAttorney(CalculationDto calculationDto)
        {

            var result = _calculationService.AttorneyFeeCalculate(calculationDto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("GetReceipt")]
        public ActionResult ReceiptCalculate(SMMH calculationDto)
        {

            var result = _calculationService.ReceiptCalculate(calculationDto);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
