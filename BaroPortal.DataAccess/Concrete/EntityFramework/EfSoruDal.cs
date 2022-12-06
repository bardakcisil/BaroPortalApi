using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Anketler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfSoruDal:ISoruDal
    {
        public Soru Add(Soru result)
        {
            using var context = new AppDbContext();
            context.Soru.Add(result);
            context.SaveChanges();
            return result;
        }

        public bool Delete(Soru result)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(result);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }


        List<Soru> ISoruDal.GetAll()
        {
            using var context = new AppDbContext();
            var result = context.Soru.ToList();
            return result;
        }
    }
}
