using BaroPortal.Entities.Concrete.Surveys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface IAnketDal
    {
        List<Surveys> GetAll();

        Surveys Add(Surveys anket);
        bool Delete(Surveys anket);
        Surveys Get(Expression<Func<Surveys, bool>>? filter = null);
    }
}
