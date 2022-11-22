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
    public class EfNewDal : INewDal
    {
        public List<New> GetDetail()
        {
            using var context = new AppDbContext();
            var _new = context.News.ToList();
            return _new;
        }

        public New Insert(New _new)
        {
            using var context = new AppDbContext();
            context.News.Add(_new);
            context.SaveChanges();
            return _new;
        }
    }
}
