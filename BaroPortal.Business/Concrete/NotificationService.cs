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
            var _bulletin = new Notification()
            {
                Title = addNotification.Title,
                Detail = addNotification.Detail,
            };
            

            var result = _notificationDal.Insert(_bulletin);
                return true;
            }


        }

        public List<Notification> ShowList()
        {
            var bulletin = _notificationDal.GetDetail();
            return bulletin; 

        }
    }
}
