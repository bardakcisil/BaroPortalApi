using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete.Surveys;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.ListDto;
using BaroPortal.Entities.Dto.Survey;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class SurveyOpsService : ISurveyOpsService
    {
        private readonly ISurveyOpsDal _opsDal;
        private readonly IConfiguration _configuration;
     

        public SurveyOpsService(ISurveyOpsDal opsDal, IConfiguration configuration)
        {
            _opsDal = opsDal;
            _configuration = configuration;
        }
        public ResultDto Add(Entities.Dto.Survey.SurveyOpsDto addSurveyOps)
        {
           
            ResultDto response = new ResultDto();
            var advert = _opsDal;

            if (advert is null)
            {
                response.HasError = true;
                response.Message = "Wrong";
                return response;
            }
            else
            {
                var _ops = new SurveyOps()
                {
                    QuestionTitle = addSurveyOps.QuestionTitle, 
                    QuestionDetail = addSurveyOps.QuestionDetail,   
                    SurveyId = addSurveyOps.SurveyId,
                    QuestionId = addSurveyOps.QuestionId,
                    AnswerId = addSurveyOps.AnswerId,
                    CreateDate = DateTime.Now,



                };


                var result = _opsDal.Add(_ops);
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
            var deleteById = _opsDal.Get(p => p.Id == id);
            if (deleteById != null)
            {
                var result = _opsDal.Delete(deleteById);
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

        public ListResultDto<Entities.Dto.Survey.SurveyOpsDto> GetList()
        {
            ListResultDto<SurveyOpsDto> response = new ListResultDto<SurveyOpsDto>();
            var result = _opsDal.GetAll();
            var data = new List<SurveyOpsDto>();
            foreach (var item in result)
            {
                SurveyOpsDto dto = new SurveyOpsDto();
                dto.QuestionTitle = item.QuestionTitle;
                dto.QuestionDetail=item.QuestionDetail;
                dto.QuestionId = item.QuestionId;
                dto.SurveyId = item.SurveyId;
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


        public IResult AddAnswer(AddSurveyOpsDto surveyOpsDto)
        {
            bool isSonuc = true;

            foreach (var anket in surveyOpsDto.GetAnswerFromListSoru)

            {

               //var result = _opsDal.AddAnswer(anket.SurveyId, anket.QuestionId, anket.AnswerId);
                var _ops = new SurveyOps()
                {
                    QuestionTitle = anket.QuestionTitle,
                    QuestionDetail = anket.QuestionDetail,
                    SurveyId = anket.SurveyId,
                    QuestionId = anket.QuestionId,
                    AnswerId = anket.AnswerId,
                    CreateDate = DateTime.Now,



                };
                var result = _opsDal.Add(_ops);

                if (result is null)
                {
                    isSonuc = false;
                }
            }

            if (isSonuc) return new SuccessResult("başarılı");
            else return new ErrorResult("başarısız");

        }
    }
}
