using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Duyurular;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Announcements;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class DuyuruService : IDuyuruService
    {

        private readonly IDuyurularDal _duyuruDal;
        private readonly IConfiguration _configuration;

        public DuyuruService(IDuyurularDal duyuruDal, IConfiguration configuration)
        {
            _duyuruDal = duyuruDal;
            _configuration = configuration;
        }
        public bool Add(UploadDto addDuyuru)
        {
            var duyuru = _duyuruDal;
            var title = addDuyuru.Title;
            var file = addDuyuru.PdfFile; 
            

            byte[] fileContent = null;
            if (file.Length > 0)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                fileContent = ms.ToArray();



            }
            if (duyuru is null) { return false; }
            else
            {
                var _duyuru = new Duyurular()
                {
                    Title = addDuyuru.Title,
                    Detail = addDuyuru.Detail,
                    ListImage = addDuyuru.ListImage,
                    DetailImage = addDuyuru.DetailImage,
                    FileName = file.FileName,
                    FilePath = Path.GetExtension(file.FileName),
                    FileSize = file.ContentType,
                    FileExtension = file.ContentType,
                    PdfFile = fileContent,
                    CreateDate = DateTime.Now,

                };


                var result = _duyuruDal.Insert(_duyuru);
                return true;
            }

        }

        public IDataResult<ResultDto> DeleteAd(int id)
        {
            var deleteById = _duyuruDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _duyuruDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Duyuru Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Duyuru Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Duyuru Silinemedi");
            }
        }


        public FileStream SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
        {
            using var stream = File.Create(filePath);
            stream.Write(data, 0, data.Length);
            return stream;
        }
        ListResultDto<GetPdfDto> IDuyuruService.GetList()
        {
            ListResultDto<GetPdfDto> response = new ListResultDto<GetPdfDto>();
            var result = _duyuruDal.GetAll();
            var data = new List<GetPdfDto>();

            foreach (var item in result)
            {


                GetPdfDto dto = new GetPdfDto();
               
                dto.PdfFile = item.PdfFile;
                dto.FilePath=item.FilePath;
                dto.FileName = item.FileName;
                dto.FileSize = item.FileSize;
                //dto.Pdf = SaveByteArrayToFileWithFileStream(dto.PdfFile, dto.FilePath);






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
    }
}
