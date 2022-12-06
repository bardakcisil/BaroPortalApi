using BaroPortal.Entities.Concrete.Haberler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IHaberlerDal
    {
        List<Haberler> GetAll();
        Haberler Insert(Haberler notification);
        bool Delete(Haberler notification);
        Haberler Get(Expression<Func<Haberler, bool>>? filter = null);
    }
}
