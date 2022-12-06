using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Uygulamalarımız;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.OtherApps;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class UygulamalarimizService: IUygulamalarimizService
    {
        private readonly IUygulamalarimizDal _uygulamaDal;
        private readonly IConfiguration _configuration;

        public UygulamalarimizService(IUygulamalarimizDal uygulamaDal, IConfiguration configuration)
        {
            _uygulamaDal = uygulamaDal;
            _configuration = configuration;
        }
        public bool Add(AppDto addUygulama)
        {
            var uygulama = _uygulamaDal;
            if (uygulama is null) { return false; }
            else
            {
                var _uygulama = new Uygulamalarimiz()
                {
                    Title = addUygulama.Title,
                    Detail = addUygulama.Detail,
                    ListImage = addUygulama.ListImage,
                    DetailImage = addUygulama.DetailImage,
                    Url = addUygulama.Url,

                };


                var result = _uygulamaDal.Insert(_uygulama);
                return true;
            }

        }

        public IDataResult<ResultDto> DeleteAd(int id)
        {
            var deleteById = _uygulamaDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _uygulamaDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Uygulama Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Uygulama Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Uygulama Silinemedi");
            }
        }

        public ListResultDto<AppDto> GetList()
        {
            ListResultDto<AppDto> response = new ListResultDto<AppDto>();
            var result = _uygulamaDal.GetAll();
            var data = new List<AppDto>();
            foreach (var item in result)
            {
                AppDto dto = new AppDto();
                dto.Title = item.Title;

                dto.Detail = item.Detail;
                dto.ListImage = item.ListImage;
                dto.DetailImage = item.DetailImage;
                dto.Url = item.Url; 


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
