﻿using BaroPortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IEventDal
    {
        List<Event> GetDetail();
         Event Insert(Event _event);
    }
}