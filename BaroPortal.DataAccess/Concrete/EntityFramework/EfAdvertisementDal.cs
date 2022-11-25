using BaroPortal.DataAccess.Abstract;
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
    public class EfAdvertisementDal :IAdvertisementDal
    {

        public Advertisement Add(Advertisement advert)
        {
            using var context = new AppDbContext();
            context.Advertisements.Add(advert);
            context.SaveChanges();
            return advert;
        }

        public void Delete(Advertisement advert)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedAd = context.Entry(advert);
                deletedAd.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

 

        public Advertisement Get(Expression<Func<Advertisement, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<Advertisement>().SingleOrDefault(filter);
            }
        }

        List<Advertisement> IAdvertisementDal.GetAll()
        {
            using var context = new AppDbContext();
            var advert = context.Advertisements.ToList();
            return advert;
        }

        public List<Advertisement> GetByType(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                //ontext.Set<Advertisement>().SingleOrDefault(filter);
                var result = context.Advertisements.Where(p => p.TypeId == id).Include(p => p.AdvertType).ToList();


                return result;


                /* (from p in context.Advertisements
                           join c in context.AdvertType
                           on p.TypeId equals c.TypeId
                           select new Advertisement
                           {
                               TypeId = p.TypeId,
                               Title = p.Title,
                               Description = p.Description,
                               Advertiser = p.Advertiser,
                               AdvertiserPhone = p.AdvertiserPhone,
                               AdvertiserEmail = p.AdvertiserEmail,
                               AdvertId = p.AdvertId,
                               AdvertType = p.AdvertType,
                           }).ToList(); */







            }
        }
    }
}
