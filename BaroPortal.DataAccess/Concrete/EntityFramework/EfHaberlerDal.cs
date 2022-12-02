using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Haberler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfHaberlerDal:IHaberlerDal
    {
        public bool Delete(Haberler notification)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(notification);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Haberler Get(Expression<Func<Haberler, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Haberler>().SingleOrDefault(filter);
            }
        }

        public List<Haberler> GetAll()
        {
            using var context = new AppDbContext();
            var notification = context.Haberler.ToList();
            return notification;
        }

        public Haberler Insert(Haberler notification)
        {
            using var context = new AppDbContext();
            context.Haberler.Add(notification);
            context.SaveChanges();
            return notification;
        }
    }
}
