using BaroPortal.Entities.Concrete.Uygulamalarımız;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IUygulamalarimizDal
    {
        List<Uygulamalarimiz> GetAll();
        Uygulamalarimiz Insert(Uygulamalarimiz uygulama);
        bool Delete(Uygulamalarimiz uygulama);
        Uygulamalarimiz Get(Expression<Func<Uygulamalarimiz, bool>>? filter = null);
    }
}
