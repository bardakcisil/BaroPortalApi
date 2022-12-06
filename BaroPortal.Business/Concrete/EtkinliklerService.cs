using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Etkinlikler;
using BaroPortal.Entities.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class EtkinliklerService : IEtkinliklerService
    {
        private readonly IEtkinliklerDal _bildirimDal;
        private readonly IConfiguration _configuration;

        public EtkinliklerService(IEtkinliklerDal bildirimDal, IConfiguration configuration)
        {
            _bildirimDal = bildirimDal;
            _configuration = configuration;
        }
        public bool Add(AddDto addBulletin)
        {
            var bildirim = _bildirimDal;
            if (bildirim is null) { return false; }
            else
            {
                var _bildirim = new Etkinlikler()
                {
                    Title = addBulletin.Title,
                    Detail = addBulletin.Detail,
                   ListImage = addBulletin.ListImage,
                    DetailImage = addBulletin.DetailImage,
                };


                var result = _bildirimDal.Insert(_bildirim);
                return true;
            }

        }

        public IDataResult<ResultDto> DeleteAd(int id)
        {
            var deleteById = _bildirimDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _bildirimDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Bildirim Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Bildirim Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Bildirim Silinemedi");
            }
        }

        public ListResultDto<GetDto> GetList()
        {
            ListResultDto<GetDto> response = new ListResultDto<GetDto>();
            var result = _bildirimDal.GetAll();
            var data = new List<GetDto>();
            foreach (var item in result)
            {
                GetDto dto = new GetDto();
                dto.Title = item.Title;

                dto.Detail = item.Detail;
                dto.ListImage = item.ListImage;
                dto.DetailImage = item.DetailImage;


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
