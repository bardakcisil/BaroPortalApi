using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface INotificationDal
    {
        List<Notification> GetDetail();
        Notification Insert(Notification bulletin);
    }
}
