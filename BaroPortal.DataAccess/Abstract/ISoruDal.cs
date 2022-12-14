
using BaroPortal.Entities.Concrete.Surveys;
using BaroPortal.Entities.Dto.Survey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface ISoruDal
    {
        List<Questions> GetAll();

        Questions Add(Questions Questions);
        bool Delete(Questions Questions);
        Questions Get(Expression<Func<Questions, bool>>? filter = null);
        List<Questions> GetBySurvey(int? id);
        bool Update(int anketId, int soruId,int answerId);
        //bool Update(int anketId, int answerId);
    }
}
