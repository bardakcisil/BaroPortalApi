using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.ContactUs;
using BaroPortal.Entities.Dto.ListDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IContactUsService
    {
        ListResultDto<GetContactUsDto> GetList();

        ResultDto AddContactUs(AddContactUsDto contatcUs);
    }
}
