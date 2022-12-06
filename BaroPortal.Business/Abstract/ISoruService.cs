using BaroPortal.Core.Result;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface ISoruService
    {
        ResultDto Add(SoruDto addSoru);
        ListResultDto<SoruDto> GetList();
        IDataResult<ResultDto> DeleteAd(int id);
        ListResultDto<GetQuestionListDto> GetBySurveyId(int id);
    }
}
