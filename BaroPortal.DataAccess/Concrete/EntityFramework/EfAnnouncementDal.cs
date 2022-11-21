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
    public class EfAnnouncementDal : IAnnouncementDal
    {
        public List<Announcement> GetDetail()
        {
            using var context = new AppDbContext();
            var announcement = context.Announcements.ToList();
            return announcement;
        }

        public Announcement Insert(Announcement announcement)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Announcements.Add(announcement);
                context.SaveChanges();
                return announcement;
            }
            
            
        }
    }
}
