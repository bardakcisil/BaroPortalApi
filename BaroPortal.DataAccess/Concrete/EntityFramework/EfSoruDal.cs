using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Surveys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfSoruDal:ISoruDal
    {
        public Questions Add(Questions result)
        {
            using var context = new AppDbContext();
            context.Questions.Add(result);
            context.SaveChanges();
            return result;
        }

        public bool Delete(Questions result)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(result);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Questions Get(Expression<Func<Questions, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Questions>().SingleOrDefault(filter);
            }
        }

        List<Questions> ISoruDal.GetAll()
        {
            using var context = new AppDbContext();
            var result = context.Questions.ToList();
            return result;
        }



        public List<Questions> GetBySurvey(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {

                var result = context.Questions.Where(p => p.SurveyId == id).Include(p => p.Survey).ToList();
                return result;

            }
        }
    }
}
