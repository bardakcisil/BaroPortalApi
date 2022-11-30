using BaroPortal.Business.Abstract;
using BaroPortal.Core.Entities;
using BaroPortal.Core.Result;
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
    public class NotificationService : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        private readonly IConfiguration _configuration;

        public NotificationService(INotificationDal notificationDal, IConfiguration configuration)
        {
            _notificationDal = notificationDal; 
            _configuration = configuration; 
        }


        public bool Add(AddNotificationDto addNotification)
        {
            var notification = _notificationDal;
                if(notification is null) { return false; } else { 
            var _notification = new Notification()
            {
                Title = addNotification.Title,
                Detail = addNotification.Detail,
            };
            

            var result = _notificationDal.Insert(_notification);
                return true;
            }


        }

        public IDataResult<List<GetNotificationDto>> GetList()
        {
            var result = _notificationDal.GetAll();
            var data = new List<GetNotificationDto>();
            foreach (var item in result)
            {
                GetNotificationDto dto = new GetNotificationDto();
                dto.Title = item.Title;

                dto.Detail = item.Detail;


                data.Add(dto);
            }
            
                return new SuccessDataResult<List<GetNotificationDto>>(data,"Liste görüntülendi");
            

        }
    }
}
