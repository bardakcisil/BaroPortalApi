﻿using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfAdvertDal:IAdvertDal
    {
  

        //public Advert GetAllByCategory(string advertTypeName)
        //{
        //    using var context = new AppDbContext();
        //    var advert = context.Adverts.SingleOrDefault(x => x.AdvertTypeName == advertTypeName);
        //    return advert;
        //}

        public Advert Insert(Advert advert)
        {
            using var context = new AppDbContext();
            context.Adverts.Add(advert);
            context.SaveChanges();
            return advert;
        }

        public List<Advert> GetAll()
        {
            using var context = new AppDbContext();
            var advert = context.Adverts.ToList();
            return advert;
        }

        public void Delete(Advert advert)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(advert);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }
        public Advert Get(Expression<Func<Advert, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Advert>().SingleOrDefault(filter);
            }
        }

        //public Advert GetAllByConscriptionStatus(string conscription)
        //{
        //    using var context = new AppDbContext();
        //    var advert = context.Adverts.SingleOrDefault(x =>x.ConscriptionStatus== conscription);
        //    return advert;
        //}
    }
}
