using BaroPortal.Entities.Concrete.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IContactUsDal
    {
        List<ContactUs> GetAll();

        ContactUs Add(ContactUs contact);
    }
}
