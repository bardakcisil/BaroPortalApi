using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfNotificationDal : INotificationDal
    {


        public List<Notification> GetAll()
        {
            using var context = new AppDbContext();
            var notification = context.Notifications.ToList();
            return notification;

        }

        public Notification Insert(Notification notification)
        {
            using var context = new AppDbContext();
            context.Notifications.Add(notification);
            context.SaveChanges();
            return notification;
        }
    }
}
