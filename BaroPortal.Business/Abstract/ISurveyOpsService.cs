using BaroPortal.Core.Result;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.ListDto;
using BaroPortal.Entities.Dto.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface ISurveyOpsService
    {
        ResultDto Add(SurveyOpsDto addSurveyOps);
        ListResultDto<SurveyOpsDto> GetList();
        IDataResult<ResultDto> Delete(int id);
        IResult AddAnswer(AddSurveyOpsDto surveyOpsDto);

    }
}
