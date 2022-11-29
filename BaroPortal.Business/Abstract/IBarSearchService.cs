
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IBarSearchService
    {
        bool AddLawyer(BaroSearchDto barosearchDto);
        BarSearch GetTypeById(int id, string name, string surname, int snumber);



        // List<BarSearch> GetbyKeyword(string keyword);
    }
}
