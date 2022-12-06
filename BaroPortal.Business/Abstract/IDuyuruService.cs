using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete.Duyurular;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IDuyuruService
    {
        bool Add(UploadDto addDuyuru);
        ListResultDto<GetDto> GetList();
        IDataResult<ResultDto> DeleteAd(int id);
  

    }
}
