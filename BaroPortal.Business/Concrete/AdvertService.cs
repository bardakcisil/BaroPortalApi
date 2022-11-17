using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class AdvertService : IAdvertService
    {
        private readonly IAdvertDal _advertDal;
        private readonly IConfiguration _configuration;
        public string AdvertNumber;
        

        public AdvertService(IAdvertDal advertDal, IConfiguration configuration)
        {
            _advertDal = advertDal;
            _configuration = configuration;
        }

        public bool AddAdvert(AddAdvertDto addAdvert)
        {
            var advert = _advertDal;

            if (advert is null)
            {
                return false;
            }

            else

            {
               
               var _advert = new Advert()
                {
                    Title = addAdvert.Title,
                    AdvertId = addAdvert.AdvertId,
                    AdvertiserName = addAdvert.AdvertiserName,
                    AdvertiserSname = addAdvert.AdvertiserSname,
                   AdvertTypeName = addAdvert.AdvertTypeName,
                   ConscriptionStatus = addAdvert.Conscription,
               
                    AdvertiserEmail = addAdvert.AdvertiserEmail,
                    AdvertiserLwork = addAdvert.AdvertiserLwork,
                    AdvertiserPhone = addAdvert.AdvertiserPhone,
                    Detail = addAdvert.Detail,
                };
                var result = _advertDal.Insert(_advert);
                return true;
            }




            

        }

        public List<Advert> GetAll()
        {
            var advert = _advertDal.GetAll();
            return advert;
        }

     
    }

}
