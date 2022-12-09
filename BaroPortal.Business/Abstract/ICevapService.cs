
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface ICevapService
    {
        ListResultDto<CevapDto> ShowList();
    }
}
