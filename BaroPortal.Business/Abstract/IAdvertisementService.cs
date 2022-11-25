using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IAdvertisementService
    {
        List<AddAdvertisementDto> GetAll();

        bool AddAdvertisement(AddAdvertisementDto addAdvert);
        List<GetAdvertisementDto> GetByTypeId(int id);
        bool DeleteAd(int id);
    }
}
