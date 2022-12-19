using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Announcements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IEducationService
    {
        bool Add(AddEducationDto addEducations);
        List<Education> ShowList();
        ListResultDto<GetTitle> GetList();
        //ListResultDto<GetPdfDto> GetPdf();
        GetPdfDto GetPdf(int id);
        IFormFile Base64ToImage(string base64String);
    }
}
