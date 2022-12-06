using BaroPortal.Entities.Concrete.Etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IEtkinliklerDal
    {
        List<Etkinlikler> GetAll();
        Etkinlikler Insert(Etkinlikler notification);
        bool Delete(Etkinlikler notification);
        Etkinlikler Get(Expression<Func<Etkinlikler, bool>>? filter = null);
    }
}
