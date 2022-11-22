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
    public class EfEventDal : IEventDal
    {


        public List<Event> GetDetail()
        {
            using var context = new AppDbContext();
            var _event = context.Events.ToList();
            return _event;

        }

        public Event Insert(Event _event)
        {
            using var context = new AppDbContext();
            context.Events.Add(_event);
            context.SaveChanges();
            return _event;
        }
    }
}
