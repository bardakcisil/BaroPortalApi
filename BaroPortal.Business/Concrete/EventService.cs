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
    public class EventService : IEventsService
    {
        private readonly IEvenstDal _eventsDal;
        private readonly IConfiguration _configuration;



        public EventService(IEvenstDal eventsDal, IConfiguration configuration)
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
                var _event = new Events()
                {
                    image = addEvents.image,
                    Title = addEvents.Title,
                    Detail = addEvents.Detail,
                };


                var result = _eventsDal.Insert(_event);
                return true;
            }
        }

        public List<Events> ShowList()
        {
            var events = _eventsDal.GetEventsDetail();
            return events;
        }
    }
}
