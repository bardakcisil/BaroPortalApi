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
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        private readonly IConfiguration _configuration;
        


        public AnnouncementService(IAnnouncementDal bulletinDal, IConfiguration configuration)
        {
            _announcementDal = bulletinDal;
            _configuration = configuration;
        }


        public bool Add(AddAnnouncementDto addAnnouncement)
        {
            var announcement = _announcementDal;
            if (announcement is null) { return false; }
            else
            {
                var _announcement = new Announcement()
                {
                    ImageData = addAnnouncement.ImageData,
                    Title = addAnnouncement.Title,
                    Detail = addAnnouncement.Detail,
                };


                var result = _announcementDal.Insert(_announcement);
                return true;
            }
        }

        public List<Announcement> ShowList()
        {
            var announcement = _announcementDal.GetDetail();
            return announcement;
        }
    }
}
