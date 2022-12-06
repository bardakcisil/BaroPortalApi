using BaroPortal.Entities.Concrete.Bildirimler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IBildirimlerDal
    {
        List<Bildirimler> GetAll();
        Bildirimler Insert(Bildirimler notification);
        bool Delete(Bildirimler notification);
        Bildirimler Get(Expression<Func<Bildirimler, bool>>? filter = null);
    }
}
