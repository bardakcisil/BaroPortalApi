using BaroPortal.Business.Abstract;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class CalculationService : ICalculationService
    {
        public ResponseCalculationDto Calculate(CalculationDto calcDto)
        {
            ResponseCalculationDto response = new ResponseCalculationDto();




            if (calcDto.Status == "Bekar")
            {
                response.bill = 15;
                response.total = 25;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" || calcDto.partnerWork == "Çalışmıyor" || calcDto.children == 0)
            {
                response.total = 0.0;
                response.bill = 10.0;
                response.HasError = false;
                response.Message = "success";
            }
            else if (calcDto.Status == "Evli" ||  calcDto.partnerWork == "Çalışıyor" || calcDto.children == 1)
            {
                response.total = 50;
                response.bill = 80;
                response.HasError = false;
                response.Message = "success";
            }
            
            else
            {
                response.HasError=true;
                response.Message = "Not Found";
            }



            return response;
        }

    }
}
