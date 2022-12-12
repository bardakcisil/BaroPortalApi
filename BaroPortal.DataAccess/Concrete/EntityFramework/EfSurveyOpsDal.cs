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
    public class EfSurveyOpsDal : ISurveyOpsDal
    {
        public SurveyOps Add(SurveyOps ops)
        {
            using var context = new AppDbContext();
            context.SurveyOps.Add(ops);
            context.SaveChanges();
            return ops;
        }

        public bool Delete(SurveyOps result)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(result);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public SurveyOps Get(Expression<Func<SurveyOps, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<SurveyOps>().SingleOrDefault(filter);
            }
        }

        public List<SurveyOps> GetAll()
        {
            using var context = new AppDbContext();
            var result = context.SurveyOps.ToList();
            return result;
        }
    }
}
