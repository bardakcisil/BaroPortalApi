using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfEducationDal : IEducationDal
    {
        public Education Add(Education edu)
        {


            using var context = new AppDbContext();
            context.Educations.Add(edu);
            context.SaveChanges();
            //return true;
            return edu;
      
        }

        public bool Delete(Education edu)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var delete= context.Entry(edu);
                delete.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Education Get(Expression<Func<Education, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Education>().SingleOrDefault(filter);
            }
        }

        public List<Education> GetAll()
        {
            using var context = new AppDbContext();
            var result = context.Educations.ToList();
            return result;
        }

        public List<Education> GetDetail()
        {
            using var context = new AppDbContext();
            var education = context.Educations.ToList();
            return education;
        }

        public Education GetPdfById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = context.Educations.Where(p => p.Id==id).SingleOrDefault();
                context.SaveChanges();
                return result;
            }
        }
    }



    
}
