using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Bildirimler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfBildirimlerDal : IBildirimlerDal
    {
        public bool Delete(Bildirimler notification)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(notification);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Bildirimler Get(Expression<Func<Bildirimler, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Bildirimler>().SingleOrDefault(filter);
            }
        }

        public List<Bildirimler> GetAll()
        {
            using var context = new AppDbContext();
            var notification = context.Bildirimler.ToList();
            return notification;
        }

        public Bildirimler Insert(Bildirimler notification)
        {
            using var context = new AppDbContext();
            context.Bildirimler.Add(notification);
            context.SaveChanges();
            return notification;
        }
    }
}
