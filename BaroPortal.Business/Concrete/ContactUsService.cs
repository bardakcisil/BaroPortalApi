using BaroPortal.Business.Abstract;
using BaroPortal.DataAccess.Abstract;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Concrete
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;
        private readonly IConfiguration _configuration;
        public int AdvertNumber;


        public ContactUsService(IContactUsDal contactUsDal, IConfiguration configuration)
        {
            _contactUsDal = contactUsDal;
            _configuration = configuration;
        }
        public ResultDto AddContactUs(AddContactUsDto contatcUs)
        {
            ResultDto response = new ResultDto();
            var contactus = _contactUsDal;

            if (contactus is null)
            {
                response.HasError = true;
                response.Message = "Wrong";
                return response;
            }
            else
            {
              

                var _contactus = new ContactUs()
                {
                    Name = contatcUs.Name,
                    Surname = contatcUs.Surname,
                    Message = contatcUs.Message,
                    TopicId = contatcUs.TopicId,
                    Email = contatcUs.Email,
                    CreateDate=DateTime.Now,
                };
                var result = _contactUsDal.Add(_contactus);


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

        public ListResultDto<GetContactUsDto> GetList()
        {
            ListResultDto<GetContactUsDto> response = new ListResultDto<GetContactUsDto>();
            var result = _contactUsDal.GetAll();
            var data = new List<GetContactUsDto>();
            foreach (var item in result)
            {
                GetContactUsDto dto = new GetContactUsDto();

                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.Email = item.Email;
                dto.Message = item.Message;
            


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
