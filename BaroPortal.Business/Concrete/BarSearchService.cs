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

        public BarSearch GetTypeById(int id, string name, string surname, int snum)
        {
                var Lawer = _barSearchDal.Get(p => p.TypeId == id );


            //var hero = await _userDal.SuperHeroes.FindAsync(id);
            if (Lawer is null)
            { return null; }
            else if (Lawer.Name == name || Lawer.Surname == surname || Lawer.BaroNumber ==snum)
            {
                return Lawer;
            }
            else
            { return null; }
        }
    }
}
