using BaroPortal.Core.Result;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IHaberlerService
    {
        bool Add(AddDto addBulletin);
        ListResultDto<GetDto> GetList();
        IDataResult<ResultDto> DeleteAd(int id);
    }
}
