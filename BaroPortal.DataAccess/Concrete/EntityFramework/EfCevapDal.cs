using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Anketler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfCevapDal
    {
        public List<Cevap> GetDetail()
        {
            var context = new AppDbContext();
            var result = context.Cevap.ToList();
            return result;
        }
    }
}
