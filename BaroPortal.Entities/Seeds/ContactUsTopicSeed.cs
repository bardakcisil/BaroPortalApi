using BaroPortal.Entities.Concrete.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Seeds
{

    public static class ContactUsTopicSeed
    {
        public static readonly List<ContactUsTopic> advertType = new List<ContactUsTopic>()
    {

             new   ContactUsTopic() { Id =1, TopicId = 1,Name = "Öneri", CreateDate=DateTime.Now },
            new    ContactUsTopic() { Id = 2, TopicId = 2, Name = "Bilgi", CreateDate = DateTime.Now },
             new   ContactUsTopic() { Id = 3, TopicId = 3, Name = "Şikayet", CreateDate = DateTime.Now },
            

    };
    }
}
