using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaroPortal.Entities.Dto.AddEducationDto;

namespace BaroPortal.Business.Concrete
{
    public class EducationService : IEducationService
    {
        private readonly IEducationDal _educationDal;
        private readonly IConfiguration _configuration;



        public EducationService(IEducationDal educationDal, IConfiguration configuration)
        {
            _educationDal = educationDal;
            _configuration = configuration;
        }
        public bool Add(AddEducationDto uploadDto)
        {

            var educations = _educationDal;
            if (educations is null) { return false; }
            else
            { 
                var title = uploadDto.Title;
                var file = uploadDto.PdfFile; 

                /*var upload = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", file.FileName);

                if (!Directory.Exists(upload))
                    Directory.CreateDirectory(upload);

                var filePath = Path.Combine(upload, file.FileName);

                var fileName = Path.GetFileName(filePath);*/

                byte[] fileContent = null; 
                if (file.Length > 0)
                {
                    using var ms = new MemoryStream(); 
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();


                  
                }
                var education = new Education()
                {
                    Title = title,
                    FileName = file.FileName,
                    FilePath = Path.GetExtension(file.FileName),
                    FileSize = file.ContentType,
                    FileExtension = file.ContentType,
                    PdfFile = fileContent,
                    CreateDate = DateTime.Now,
                };



                var result = _educationDal.Add(education);
                return true;
            }
        }

        public List<Education> ShowList()
        {
            var education = _educationDal.GetDetail();
            return education;
        }
    }
}
