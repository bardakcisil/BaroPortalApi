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
            var advert = _advertDal.GetAllByCategory(addAdvert.CategoryName);

            if (advert is not null)
            {
                return false;
            }

            else

            {
                //AdvertNumber = GeneratePassword();
                //string dataToSave = AdvertNumber;
                Console.WriteLine(AdvertNumber);



                advert = new Advert()
                {
                    Title = advert.Title,
                    AdvertId = advert.AdvertId,
                    AdvertiserName = advert.AdvertiserName,
                    AdvertiserSname = advert.AdvertiserSname,
                    AdvertiserEmail = advert.AdvertiserEmail,
                    AdvertiserLwork = advert.AdvertiserLwork,
                    AdvertiserPhone = advert.AdvertiserPhone,
                    Detail = advert.Detail,
                };

                advert.CreateDate = DateTime.Now;

            }




            var result = _advertDal.Insert(advert);
            return true;

        }

        public List<Advert> GetAll()
        {
            var advert = _advertDal.GetAll();
            return advert;
        }

    }

}
