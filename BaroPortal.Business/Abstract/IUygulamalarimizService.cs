using BaroPortal.Core.Result;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.OtherApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IUygulamalarimizService
    {
        bool Add(AppDto addUygulama);
        ListResultDto<AppDto> GetList();
        IDataResult<ResultDto> DeleteAd(int id);
    }
}
