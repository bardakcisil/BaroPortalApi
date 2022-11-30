using BaroPortal.Core.Result;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IAdvertisementDal
    {
        List<Advertisement> GetAll();

        Advertisement Add(Advertisement advert);
        bool Delete(Advertisement advert);
        List<Advertisement> GetByType(int id);
        Advertisement Get(Expression<Func<Advertisement, bool>>? filter = null);
        List<AdvertDetailDto> GetAdvertDetails();

    }
}
