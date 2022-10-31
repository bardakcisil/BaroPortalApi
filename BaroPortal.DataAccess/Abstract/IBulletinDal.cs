using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IBulletinDal
    {
        Bulletin GetBulletinDetail(Bulletin bulletin);
       Bulletin Insert(Bulletin bulletin);
    }
}
