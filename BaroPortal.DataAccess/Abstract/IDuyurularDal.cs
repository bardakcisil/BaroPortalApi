using BaroPortal.Entities.Concrete.Duyurular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IDuyurularDal
    {
        List<Duyurular> GetAll();
        Duyurular Insert(Duyurular duyuru);
        bool Delete(Duyurular duyuru);
        Duyurular Get(Expression<Func<Duyurular, bool>>? filter = null);
    }
}
