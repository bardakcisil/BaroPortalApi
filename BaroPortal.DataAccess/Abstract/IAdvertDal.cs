using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IAdvertDal
    {
        List<Advert> GetAll();
        //Advert GetAllByCategory(string categoryName);
        //Advert GetAllByConscriptionStatus(string conscription);
        Advert Insert(Advert advert);
    }
}
