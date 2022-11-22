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
    public class NewService : INewService
    {
        private readonly INewDal _newsDal;
        private readonly IConfiguration _configuration;



        public NewService(INewDal newsDal, IConfiguration configuration)
        {
            _newsDal = newsDal;
            _configuration = configuration;
        }


        public bool Add(AddNewDto addNews)
        {
            var news = _newsDal;
            if (news is null) { return false; }
            else
            {
                var _news = new New()
                {
                    image = addNews.image,
                    Title = addNews.Title,
                    Detail = addNews.Detail,
                };


                var result = _newsDal.Insert(_news);
                return true;
            }
        }

        public List<New> ShowList()
        {
            var news = _newsDal.GetDetail();
            return news;
        }
    }
}
