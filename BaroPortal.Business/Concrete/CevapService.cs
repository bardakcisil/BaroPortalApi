using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.Extensions.Configuration;

namespace BaroPortal.Business.Concrete

{
    public class CevapService : ICevapService
    {
        ICevapDal _cevapDal;
        IConfiguration _configuration;
        public CevapService(ICevapDal cevapDal,
        IConfiguration configuration)
        {
            _cevapDal = cevapDal;
            _configuration = configuration;

        }
        public ListResultDto<CevapDto> ShowList()
        {
            ListResultDto<CevapDto> response = new ListResultDto<CevapDto>();
            var result = _cevapDal.GetDetail();
            var data = new List<CevapDto>();
            foreach (var item in result)
            {
                CevapDto dto = new CevapDto();
                dto.Id = item.Id;   
                dto.AnswerId = item.AnswerId;
                dto.AnswerName = item.AnswerName;
             

                data.Add(dto);


            }
            response.Data = data;


            if (response.Data is not null)
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
