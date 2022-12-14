using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Advertisement;
using BaroPortal.Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IAdvertisementService
    {
        ListResultDto<GetAdvertisementListDto> GetList();

        ResultDto AddAdvertisement(AddAdvertisementDto addAdvert);
        ListResultDto<GetAdvertisementListDto> GetByTypeId(int id);
       // IDataResult<ResultDto> DeleteAd(int id);
       ResultDto DeleteAd(int id);
      
    }
}
