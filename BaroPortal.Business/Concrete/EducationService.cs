using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Educations;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Announcements;
using BaroPortal.Entities.Dto.Educations;
using BaroPortal.Entities.Dto.ListDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaroPortal.Entities.Dto.Educations.AddEducationDto;

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


                byte[]? fileContent = null;
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
                    FileExtension = file.ContentDisposition,
                    PdfFile = fileContent,
                    CreateDate = DateTime.Now,
                };



                var result = _educationDal.Add(education);
                return true;
            }
        }



        public ListResultDto<GetTitle> GetList()
        {
            ListResultDto<GetTitle> response = new ListResultDto<GetTitle>();
            var result = _educationDal.GetAll();
            var data = new List<GetTitle>();

            foreach (var item in result)
            {
                GetTitle dto = new GetTitle();
                dto.Id = item.Id;
                dto.Title = item.Title;


                data.Add(dto);
            }

            response.Data = data;

            if (data is not null)
            {
                response.HasError = false;
                response.Message = "Liste görüntülendi";
                return response;
            }
            else
            {
                response.HasError = true;
                response.Message = "Liste görüntülenmedi";
                return response;
            }
        }

        public List<Education> ShowDetail()
        {
            var education = _educationDal.GetDetail();
            return education;
        }
        //public  IFormFile Base64ToImage(string base64String) 
        //{
        //    FormFile formFile;
        //    byte[] bytes = Convert.FromBase64String(base64String);
        //    MemoryStream stream = new MemoryStream(bytes);
        //    formFile = new FormFile(stream, 0, bytes.Length, "", "");

        //    return formFile;
        //}


        public GetPdfDto GetPdf(int id)
        {

            GetPdfDto response = new GetPdfDto();
            var result = _educationDal.GetPdfById(id);

            if (result is not null && File.Exists(result.FilePath))
            {
               

                response.PdfFile = result.PdfFile;
                response.FilePath = result.FilePath;
                response.FileName = result.FileName;
                response.FileExtension = result.FileExtension;
                response.FileSize = result.FileSize;

                //string file = Convert.ToBase64String(result.PdfFile);
                // response.Pdf = Base64ToImage(file);

                string file = Convert.ToBase64String(result.PdfFile);




                response.HasError = false;
                response.Message = "Başarılı";
                return response;

           
                
               


            }
            else
            {
                response.HasError = true;
                response.Message = "Başarısız";
                return response;
               
            }


           

        }

        public IDataResult<ResultDto> Delete(int id)
        {
            var deleteById = _educationDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _educationDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>(" Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>(" Silinemedi");
            }
        }
    }
}
