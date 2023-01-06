using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete.Educations;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Announcements;
using BaroPortal.Entities.Dto.Educations;
using BaroPortal.Entities.Dto.ListDto;
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
        List<Education> ShowDetail();
        ListResultDto<GetTitle> GetList();
        //ListResultDto<GetPdfDto> GetPdf();
        GetPdfDto GetPdf(int id);
        //  IFormFile Base64ToImage(string base64String);
        IDataResult<ResultDto> Delete(int id);
    }
}
