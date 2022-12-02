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

namespace BaroPortal.Business.Concrete
{
    public class BarSearchService : IBarSearchService
    {
        string baroTitle;
        private readonly IBarSearchDal _barSearchDal;
        private readonly IConfiguration _configuration;

        public BarSearchService(IBarSearchDal barSearchDal, IConfiguration configuration)
        {
            _barSearchDal = barSearchDal;
            _configuration = configuration;
        }

        public bool AddLawyer(BaroSearchDto barosearchDto)
        {
            var search = _barSearchDal;
            if (search is null) { return false; }
            else
            {
                var _barsearch = new BarSearch()
                {
                    TypeId = barosearchDto.TypeId,
                    Name = barosearchDto.Name,
                    Surname = barosearchDto.Surname,
                    BaroNumber = barosearchDto.BaroNumber,
                };


                var result = _barSearchDal.Insert(_barsearch);
                return true;
            }
        }
        public LawyerResponseDto CheckUser(BaroSearchDto barsearchDto)
        {

            LawyerResponseDto response = new LawyerResponseDto();

            //var user = _barSearchDal.GetUserByIdentity(barsearchDto.TypeId);

            var resultList = _barSearchDal.GetAll(p => (p.TypeId == barsearchDto.TypeId) && (p.Name.Contains(barsearchDto.Name) || p.Surname.Contains(barsearchDto.Surname) || p.BaroNumber == barsearchDto.BaroNumber));
            var listDto = new List<GetBarSearchListDto>();




            foreach (var item in resultList)
            {
                GetBarSearchListDto dto = new GetBarSearchListDto();

                dto.title = item.TypeId;
                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.BarNumber = item.BaroNumber;

                listDto.Add(dto);

            }

            response.Data = listDto;

            response.Data= listDto;


            if (listDto is not null)
            {
                response.HasError = false;

                return response;
            }
            else
            {
                response.HasError = true;
                return response;
            }
        }



    }
}