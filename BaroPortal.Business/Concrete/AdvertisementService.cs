
using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Concrete.Advertisement;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.Advertisement;
using BaroPortal.Entities.Dto.ListDto;
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

   
            public ListResultDto<GetAdvertisementListDto> GetList()
        {
            ListResultDto<GetAdvertisementListDto> response = new ListResultDto<GetAdvertisementListDto>();
            var result = _advertDal.GetAll();
            var data = new List<GetAdvertisementListDto>();
            foreach (var item in result)
            {
                GetAdvertisementListDto dto = new GetAdvertisementListDto();

                dto.Advertiser = item.Advertiser;
                dto.Title = item.Title;
                dto.Advertiser = item.Advertiser;
                dto.AdvertiserPhone = item.AdvertiserPhone;
                dto.AdvertiserEmail = item.AdvertiserEmail;
                dto.Description = item.Description;
                

                data.Add(dto);
                
            }

            response.Data = data;

            if (data is not null)
            {
                response.HasError = false;
                response.Message = "Liste görüntülendi";
                return response;
            }
            else
            {
                response.HasError = true;
                response.Message = "Liste görüntülenmedi";
                return response;
            }

            
        }
      
        
        /*public IDataResult<ResultDto> DeleteAd(int id)
        {
            


            var deleteById = _advertDal.Get(p => p.AdvertId == id);
            if (deleteById != null)
            {
                var result = _advertDal.Delete(deleteById);
                if (result is true)
                {

                    return new SuccessDataResult<ResultDto>("Silindi");
                }
                else
                {
                    return new ErrorDataResult<ResultDto>("Silinemedi");
                }
            }
            else
            {
                return new ErrorDataResult<ResultDto>("Silinemedi");
            }






        }
        */

         public ResultDto DeleteAd(int id)
         {
         ResultDto response = new ResultDto();


         var deleteById = _advertDal.Get(p => p.AdvertId == id);
         if(deleteById != null)
         { 
             var result =  _advertDal.Delete(deleteById); 
             if (result)
             {
                 response.HasError = false;
                 response.Message = "İlan Silindi";
                 return response;
             }
             else {
                 response.HasError = true;
                 response.Message = "İlan Silinemedi";
                 return response; 
             } }
         else
         {
             response.HasError = true;
             response.Message = "İlan Silinemedi";
             return response;
         }

            return response;
     }

        public ResultDto AddAdvertisement(AddAdvertisementDto addAdvert)
        {
            ResultDto response = new ResultDto();   
            var advert = _advertDal;

            if (advert is null)
            {
                response.HasError = true;
                response.Message = "Wrong";
                return response;
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
                message.Body = "Sayın "+ addAdvert.Advertiser + " oluşturmuş olduğunuz " + addAdvert.Title + " içerikli ilanın ilan numarası: " + AdvertNumber + " dır. İlanınızı bu numara ile kaldırabilirsiniz.";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; // Encryption
                client.Credentials = new System.Net.NetworkCredential("baroportal@yandex.com", "nntdrirfvaajoynl");

                client.Send(message);

                if (result != null)
                {
                    response.HasError = false;
                    response.Message = "True";
                    return response;
                }
                else
                 response.HasError = true;
                response.Message = "Wrong";
                return response;

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






        ListResultDto<GetAdvertisementListDto> IAdvertisementService.GetByTypeId(int id)
        {
            ListResultDto<GetAdvertisementListDto> response = new ListResultDto<GetAdvertisementListDto>();

            var result = _advertDal.GetByType(id);
            var data = new List<GetAdvertisementListDto>();
            foreach (var item in result)
            {
                GetAdvertisementListDto dto = new GetAdvertisementListDto();
                dto.Advertiser = item.Advertiser;
                dto.Title = item.Title;
                dto.Advertiser = item.Advertiser;
                dto.AdvertiserPhone = item.AdvertiserPhone;
                dto.AdvertiserEmail = item.AdvertiserEmail;
                dto.Description = item.Description;

                data.Add(dto);
            }

            response.Data = data;

            if (data is not null)
            {
                response.HasError = false;
                response.Message = "Liste görüntülendi";
                return response;
            }
            else
            {
                response.HasError = true;
                response.Message = "Liste görüntülenmedi";
                return response;
            }
        }
    }
}
