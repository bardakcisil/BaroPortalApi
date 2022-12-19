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
    public class EfAnketDal:IAnketDal
    {
        public Surveys Add(Surveys result)
        {
            using var context = new AppDbContext();
            context.Surveys.Add(result);
            context.SaveChanges();
            return result;
        }

        public bool Delete(Surveys result)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var delete = context.Entry(result);
                delete.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Surveys Get(Expression<Func<Surveys, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Surveys>().SingleOrDefault(filter);
            }
        }

        List<Surveys> IAnketDal.GetAll()
        {
            using var context = new AppDbContext();
            var result = context.Surveys.ToList();
            return result;
        }
    }
}
