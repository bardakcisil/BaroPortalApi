using BaroPortal.Entities.Concrete.Educations;
using BaroPortal.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IEducationDal
    {
        Education Add(Education edu);
        List<Education> GetDetail();
        List<Education> GetAll();
        Education Get(Expression<Func<Education, bool>>? filter = null);
        bool Delete(Education edu);
        Education GetPdfById(int id);
    }
}
