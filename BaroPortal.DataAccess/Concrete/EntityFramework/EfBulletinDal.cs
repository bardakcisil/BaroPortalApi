using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfBulletinDal : IBulletinDal
    {


        public Bulletin GetBulletinDetail(Bulletin bulletin)
        {
            using var context = new AppDbContext();
            var bulletinTitle = context.Bulletins.SingleOrDefault(x => x.Title == Title);
            return bulletin;

        }

        public Bulletin Insert(Bulletin bulletin)
        {
            using var context = new AppDbContext();
            context.Bulletins.Add(bulletin);
            context.SaveChanges();
            return bulletin;
        }
    }
}
