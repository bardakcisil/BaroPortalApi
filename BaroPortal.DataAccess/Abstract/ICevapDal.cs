using BaroPortal.Entities.Concrete.Anketler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface ICevapDal
    {
        List<Cevap> GetDetail();
    }
}
