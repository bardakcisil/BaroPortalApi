using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Dto;
using BaroPortal.Entities.Dto.ContactUs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class ContactUsTopicService : IContactUsTopicService
    {
        private readonly IContactUsTopicDal _contactUsDal;
        private readonly IConfiguration _configuration;
        public int AdvertNumber;


        public ContactUsTopicService(IContactUsTopicDal contactUsDal, IConfiguration configuration)
        {
            _contactUsDal = contactUsDal;
            _configuration = configuration;
        }
        public ListResultDto<ContactUsTopicDto> ShowList()
        {
            ListResultDto<ContactUsTopicDto> response = new ListResultDto<ContactUsTopicDto>();
            var result = _contactUsDal.GetDetail();
            var data = new List<ContactUsTopicDto>();
            foreach (var item in result)
            {
                ContactUsTopicDto dto = new ContactUsTopicDto();

                dto.TopicId = item.TopicId;
                dto.Name = item.Name;


                data.Add(dto);


            }
            response.Data = data;


            if (response.Data is not null)
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
