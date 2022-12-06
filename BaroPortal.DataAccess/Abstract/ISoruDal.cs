using BaroPortal.Entities.Concrete.Anketler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface ISoruDal
    {
        List<Soru> GetAll();

        Soru Add(Soru soru);
        bool Delete(Soru soru);

    }
}
