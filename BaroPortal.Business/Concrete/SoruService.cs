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
    public class SoruService : ISoruService
    {
        private readonly ISoruDal _soruDal;
        private readonly IConfiguration _configuration;

        public SoruService(ISoruDal soruDal, IConfiguration configuration)
        {
            _soruDal = soruDal;
            _configuration = configuration;
        }
        public ResultDto Add(SoruDto addSoru)
        {

            ResultDto response = new ResultDto();
            var advert = _soruDal;

            if (addSoru is null)
            {
                response.HasError = true;
                response.Message = "Wrong";
                return response;
            }
            else
            {


                var _soru = new Questions()
                {

                    QuestionId = addSoru.QuestionId,
                    QuestionTitle = addSoru.QuestionTitle,
                    QuestionDetail = addSoru.QuestionDetail,
                    SurveyId = addSoru.SurveyId,
                    AnswerId = addSoru.AnswerId,
                    CreateDate = DateTime.Now,

                };
                var result = _soruDal.Add(_soru);


                if (result != null)
                {
                    response.HasError = false;
                    response.Message = "True";
                    return response;
                }
                else
                    response.HasError = true;
                response.Message = "Wrong";
                return response;

            }
        }



        public IDataResult<ResultDto> Delete(int id)
        {
            var deleteById = _soruDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _soruDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Soru Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Soru Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Soru Silinemedi");
            }
        }

        public ListResultDto<SoruDto> GetList()
        {
            ListResultDto<SoruDto> response = new ListResultDto<SoruDto>();
            var result = _soruDal.GetAll();
            var data = new List<SoruDto>();
            foreach (var item in result)
            {
                SoruDto dto = new SoruDto();

                dto.Id = item.Id;
                dto.QuestionId = item.QuestionId;
                dto.QuestionTitle = item.QuestionTitle;
                dto.QuestionDetail = item.QuestionDetail;
                dto.AnswerId = item.AnswerId;
                dto.SurveyId = item.SurveyId;


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

        public IResult UpdateAnswer(AnketAnswerDto anketAnswerDto)
        {
            bool isSonuc = true;

            foreach (var anket in anketAnswerDto.GetAnswerFromListSoru)

            {

                var result = _soruDal.Update(anket.SurveyId, anket.QuestionId, anket.AnswerId);

                if (!result)
                {
                    isSonuc = false;
                }
            }

            if (isSonuc) return new SuccessResult("başarılı");
            else return new ErrorResult("başarısız");

        }


        ListResultDto<GetQuestionListDto> ISoruService.GetBySurveyId(int? id)
        {
            ListResultDto<GetQuestionListDto> response = new ListResultDto<GetQuestionListDto>();
            
            var result = _soruDal.GetBySurvey(id);
            var data = new List<GetQuestionListDto>();
            foreach (var item in result)
            {
                GetQuestionListDto dto = new GetQuestionListDto();
               
                dto.Id = item.Id;
                dto.SurveyId = item.SurveyId;
                dto.QuestionId = item.QuestionId;
                dto.QuestionTitle = item.QuestionTitle;
                dto.QuestionDetail = item.QuestionDetail;
                dto.AnswerId = item.AnswerId;
                


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
