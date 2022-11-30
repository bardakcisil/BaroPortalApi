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
    public class EfContactUsTopicDal : IContactUsTopicDal
    {
        public List<ContactUsTopic> GetDetail()
        {
            var context = new AppDbContext();
            var result = context.ContactUsTopics.ToList();
            return result;
        }
    }
}
