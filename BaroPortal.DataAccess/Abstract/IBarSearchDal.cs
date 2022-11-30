using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IBarSearchDal
    {
        List<BarSearch> GetDetail();
        BarSearch Insert(BarSearch _barSearch);
        List<BarSearch>  GetAll(Expression<Func<BarSearch, bool>>? filter = null);
        //BarSearch GetUserByIdentity(int typeid);

    }
}
