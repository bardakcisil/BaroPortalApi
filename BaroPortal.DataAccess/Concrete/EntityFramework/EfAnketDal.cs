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
    public class EfAnketDal:IAnketDal
    {
        public Anket Add(Anket result)
        {
            using var context = new AppDbContext();
            context.Anket.Add(result);
            context.SaveChanges();
            return result;
        }

        public bool Delete(Anket result)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(result);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
                return true;

            }
        }


        List<Anket> IAnketDal.GetAll()
        {
            using var context = new AppDbContext();
            var result = context.Anket.ToList();
            return result;
        }
    }
}
