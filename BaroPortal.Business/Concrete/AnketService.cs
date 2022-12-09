using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Surveys;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class AnketService : IAnketService
    {
        private readonly IAnketDal _anketDal;
        private readonly IConfiguration _configuration;

        public AnketService(IAnketDal anketDal, IConfiguration configuration)
        {
            _anketDal = anketDal;
            _configuration = configuration;
        }
        public bool Add(AnketDto addAnket)
        {
            var anket = _anketDal;
            if (anket is null) { return false; }
            else
            {
                var _anket = new Surveys()
                {
                    SurveyId = addAnket.SurveyId,
                    SurveyName = addAnket.SurveyName,



                };


                var result = _anketDal.Add(_anket);
                return true;
            }
        }

        public IDataResult<ResultDto> Delete(int id)
        {
            var deleteById = _anketDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _anketDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Anket Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Anket Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Anket Silinemedi");
            }
        }

        public ListResultDto<AnketDto> GetList()
        {
            ListResultDto<AnketDto> response = new ListResultDto<AnketDto>();
            var result = _anketDal.GetAll();
            var data = new List<AnketDto>();
            foreach (var item in result)
            {
                AnketDto dto = new AnketDto();
                dto.Id = item.Id;     
                dto.SurveyId = item.SurveyId;
                dto.SurveyName= item.SurveyName;


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
