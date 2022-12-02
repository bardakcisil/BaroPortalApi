using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfContactUsDal : IContactUsDal
    {
        public ContactUs Add(ContactUs contact)
        {
            using var result = new AppDbContext();
            result.ContactUs.Add(contact);
            result.SaveChanges();
            return contact;
        }

        public List<ContactUs> GetAll()
        {
            using var context = new AppDbContext();
            var result = context.ContactUs.ToList();
            return result;
        }
    }
}
