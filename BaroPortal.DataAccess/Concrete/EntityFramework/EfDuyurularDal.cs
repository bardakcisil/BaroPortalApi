using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Duyurular;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfDuyurularDal : IDuyurularDal
    {
        public bool Delete(Duyurular duyuru)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(duyuru);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Duyurular Get(Expression<Func<Duyurular, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Duyurular>().SingleOrDefault(filter);
            }
        }

        public List<Duyurular> GetAll()
        {
            using var context = new AppDbContext();
            var notification = context.Duyurular.ToList();
            return notification;
        }

        public Duyurular Insert(Duyurular duyuru)
        {
            using var context = new AppDbContext();
            context.Duyurular.Add(duyuru);
            context.SaveChanges();
            return duyuru;
        }
    }
}
