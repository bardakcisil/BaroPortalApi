using BaroPortal.Entities.Concrete.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IAdvTypeDal
    {
        List<AdvType> GetDetail();
    }
}
