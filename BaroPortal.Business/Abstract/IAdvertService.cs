﻿using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Business.Abstract
{
    public interface IAdvertService
    {
        List<Advert> GetAll();
        
        bool AddAdvert(AddAdvertDto addAdvert);
        //Task<List<Advert>?> DeleteAd(int id);
        bool DeleteAd(int id);

    }
}
