using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Uygulamalarımız;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfUygulamalarimizDal : IUygulamalarimizDal
    {
        public bool Delete(Uygulamalarimiz uygulama)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(uygulama);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }

        public Uygulamalarimiz Get(Expression<Func<Uygulamalarimiz, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Uygulamalarimiz>().SingleOrDefault(filter);
            }
        }

        public List<Uygulamalarimiz> GetAll()
        {
            using var context = new AppDbContext();
            var uygulama = context.Uygulamalarimiz.ToList();
            return uygulama;
        }

        public Uygulamalarimiz Insert(Uygulamalarimiz uygulama)
        {
            using var context = new AppDbContext();
            context.Uygulamalarimiz.Add(uygulama);
            context.SaveChanges();
            return uygulama;
        }
    }
}
