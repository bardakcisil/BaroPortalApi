using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface ICalculationService
    {
        ResponseCalculationDto LivingFeeCalculate(CalculationDto calcDto);
        ResponseCalculationDto AttorneyFeeCalculate(CalculationDto calcDto);
        SMMHResultDto ReceiptCalculate(SMMH calcDto);
        ResponseCalculationDto LevyInterestCalculate(IFH calcDto);
        //ResponseCalculationDto LevyMortarCalculate(IHH calcDto);
    }
}
