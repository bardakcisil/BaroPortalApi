using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto.Advertisement;
using BaroPortal.Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IAdvTypeService
    {
        ListResultDto<AdvTypeDto> ShowList();
    }
}
