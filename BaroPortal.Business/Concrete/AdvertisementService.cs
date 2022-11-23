
using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class AdvertisementService : IAdvertisementService
    {
        
            private readonly IAdvertisementDal _advertDal;
            private readonly IConfiguration _configuration;
            public int AdvertNumber;


            public AdvertisementService(IAdvertisementDal advertDal, IConfiguration configuration)
            {
                _advertDal = advertDal;
                _configuration = configuration;
            }

   
            public List<AddAdvertisementDto> GetAll()
            {
                var result = _advertDal.GetAll();
            var data = new List<AddAdvertisementDto>();
            foreach (var item in result)
            {
                AddAdvertisementDto dto = new AddAdvertisementDto();
                dto.AdvertId = item.AdvertId;
                dto.Title = item.Title;
                dto.Advertiser = item.Advertiser;
                dto.TypeId = item.TypeId;
                dto.AdvertiserEmail = item.AdvertiserEmail;
                dto.AdvertiserPhone = item.AdvertiserPhone;
                dto.Description = item.Description;
                

                data.Add(dto);
            }



            //advertDal.Get();
            return data;
        }



            public bool DeleteAd(int id)
            {

                var result = _advertDal.Get(p => p.AdvertId == id);
                _advertDal.Delete(result);
                return true;
            }

        public bool AddAdvertisement(AddAdvertisementDto addAdvert)
        {
            var advert = _advertDal;

            if (advert is null)
            {
                return false;
            }
            else
            {
                AdvertNumber = GenerateAdNumber();
                Console.WriteLine(AdvertNumber);

                var _advert = new Advertisement()
                {
                    Title = addAdvert.Title,
                    AdvertId = AdvertNumber,
                    Advertiser = addAdvert.Advertiser,
                    TypeId = addAdvert.TypeId,
                    AdvertiserEmail = addAdvert.AdvertiserEmail,
                    AdvertiserPhone = addAdvert.AdvertiserPhone,
                    Description = addAdvert.Description,
                };
                var result = _advertDal.Add(_advert);



                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress("baroportal@yandex.com");
                message.To.Add(addAdvert.AdvertiserEmail);
                message.Subject = "Baro İlanı Hakkında"; 
                message.Body = "Sayın "+ addAdvert.Advertiser + "oluşturmuş olduğunuz " + addAdvert.Title + "içerikli ilanın ilan numarası: " + AdvertNumber + " dır. İlanınızı bu numara ile kaldırabilirsiniz.";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Encryption
                client.Credentials = new System.Net.NetworkCredential("baroportal@yandex.com", "nntdrirfvaajoynl");

                client.Send(message);

                if (result != null)
                {
                    return true;
                }
                else
                    return false;

            }
        }


        public int GenerateAdNumber()
        {
            string IdLength = "5";
            string AdNumber = "";
            int AdvertismentNum;

            string allowedChars = "";
            allowedChars = "1,2,3,4,5,6,7,8,9,0";


            char[] sep = {
                ','
            };
            string[] arr = allowedChars.Split(sep);


            string IDString = "";
            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < Convert.ToInt32(IdLength); i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                IDString += temp;
                AdNumber = IDString;

            }
            AdvertismentNum = Convert.ToInt32(AdNumber);
            return AdvertismentNum;
        }

        public List<GetAdvertisementDto> GetByTypeId(int id)
        {

          
          var result = _advertDal.GetByType(id);
            var data = new List<GetAdvertisementDto>();
            foreach(var item in result)
            {
                GetAdvertisementDto dto = new GetAdvertisementDto();
                dto.AdvertId = item.AdvertId;
                dto.Title = item.Title;
                dto.Advertiser = item.Advertiser;
                dto.TypeId = item.TypeId;
                dto.AdvertiserEmail = item.AdvertiserEmail;
                dto.AdvertiserPhone = item.AdvertiserPhone;
                dto.Description = item.Description;
                dto.Name = item.AdvertType.Name;

                data.Add(dto);
            }

          
   
          //advertDal.Get();
            return data;
        }
    }
}
