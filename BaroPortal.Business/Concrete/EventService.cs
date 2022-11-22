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
    public class EventService : IEventService
    {
        private readonly IEventDal _eventsDal;
        private readonly IConfiguration _configuration;



        public EventService(IEventDal eventsDal, IConfiguration configuration)
        {
            _eventsDal = eventsDal;
            _configuration = configuration;
        }


        public bool Add(AddEventDto addEvents)
        {
            var events = _eventsDal;
            if (events is null) { return false; }
            else
            {
                var _event = new Event()
                {
                    image = addEvents.image,
                    Title = addEvents.Title,
                    Detail = addEvents.Detail,
                };


                var result = _eventsDal.Insert(_event);
                return true;
            }
        }

        public List<Event> ShowList()
        {
            var events = _eventsDal.GetDetail();
            return events;
        }
    }
}
