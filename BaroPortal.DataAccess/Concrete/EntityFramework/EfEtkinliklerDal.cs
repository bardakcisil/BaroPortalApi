using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Bildirimler;
using BaroPortal.Entities.Concrete.Etkinlikler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfEtkinliklerDal : IEtkinliklerDal
    {
        public bool Delete(Etkinlikler notification)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(notification);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Etkinlikler Get(Expression<Func<Etkinlikler, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Etkinlikler>().SingleOrDefault(filter);
            }
        }

        public List<Etkinlikler> GetAll()
        {
            using var context = new AppDbContext();
            var notification = context.Etkinlikler.ToList();
            return notification;
        }

        public Etkinlikler Insert(Etkinlikler notification)
        {
            using var context = new AppDbContext();
            context.Etkinlikler.Add(notification);
            context.SaveChanges();
            return notification;
        }
    }
}
