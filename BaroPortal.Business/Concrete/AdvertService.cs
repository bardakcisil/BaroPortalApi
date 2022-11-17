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
        public int AdvertNumber;
        

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
                AdvertNumber = GenerateAdNumber();
                Console.WriteLine(AdvertNumber);

                var _advert = new Advert()
                {
                    Title = addAdvert.Title,
                    AdvertId =  AdvertNumber,
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
               


            SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
            MailMessage message = new MailMessage();
            message.From = new MailAddress("baroportal@yandex.com");
            message.To.Add(addAdvert.AdvertiserEmail);
            message.Subject = "Sayın " + addAdvert.AdvertiserName + " " + addAdvert.AdvertiserSname;
            message.Body = "ilanın ilan numarası: " + AdvertNumber + ", İlanınızı bu numara ile kaldırabilirsiniz ";
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
            string AdNumber ="";
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
        public List<Advert> GetAll()
        {
            var advert = _advertDal.GetAll();
            return advert;
        }

      

        public bool DeleteAd(int id)
        {
            
            var result = _advertDal.Get(p => p.AdvertId == id);
            _advertDal.Delete(result);
            return true;
        }

        //public async Task<List<Advert>?> DeleteAd(int id)
        //{
        //    var ad =  new  Advert();

        //     await ad.FindAsync(id);
        //    if (ad is null)
        //        return null;

        //    _advertDal.Advert.Remove(ad);
        //    await _advertDalt.SaveChangesAsync();

        //    return await _context.SuperHeroes.ToListAsync();
        //}


    }

}
