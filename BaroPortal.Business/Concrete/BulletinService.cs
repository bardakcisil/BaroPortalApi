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
    public class BulletinService : IBulletinService
    {
        private readonly IBulletinDal _bulletinDal;
        private readonly IConfiguration _configuration;

        public BulletinService(IBulletinDal bulletinDal, IConfiguration configuration)
        {
            _bulletinDal = bulletinDal; 
            _configuration = configuration; 
        }

        public bool AddBulletin(AddBulletin addBulletin)
        {
            var bulletin = new Bulletin()
            {
                Title = addBulletin.Title,
                Detail = addBulletin.Detail,
            };

            var result = _bulletinDal.Insert(bulletin);

            if (result) return true;
            else return false;
            
        }

        public List<Bulletin> ShowBulletin()
        {
            throw new NotImplementedException();
        }
    }
}
