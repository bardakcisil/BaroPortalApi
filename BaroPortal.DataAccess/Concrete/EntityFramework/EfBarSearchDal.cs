using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfBarSearchDal : IBarSearchDal
    {
        public BarSearch Get(Expression<Func<BarSearch, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<BarSearch>().SingleOrDefault(filter);
            }
        }

        public List<BarSearch> GetDetail()
        {
            using var context = new AppDbContext();
            var _barSearch = context.BarSearch.ToList();
            return _barSearch;

        }

        public BarSearch Insert(BarSearch _barSearch)
        {
            using var context = new AppDbContext();
            context.BarSearch.Add(_barSearch);
            context.SaveChanges();
            return _barSearch;
        }

        //testing

        public BarSearch GetUserByIdentity(int typeid)
        {
            using var context = new AppDbContext();
            var user = context.BarSearch.SingleOrDefault(x => x.TypeId == typeid);
            return user;
        }

        public List<BarSearch> GetAll(Expression<Func<BarSearch, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null
                    ? context.Set<BarSearch>().ToList()
                    : context.Set<BarSearch>().Where(filter).ToList();

            }
        }
    }
}
