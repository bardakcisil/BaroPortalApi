using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfEducationDal : IEducationDal
    {
        public bool Add(Education _education)
        {


            using var context = new AppDbContext();
            context.Educations.Add(_education);
            context.SaveChanges();
            return true;
            //return _education;
      
        }

        public List<Education> GetDetail()
        {
            using var context = new AppDbContext();
            var education = context.Educations.ToList();
            return education;
        }
    }



    
}
