using BaroPortal.Entities.Concrete.Surveys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Abstract
{
    public interface ISurveyOpsDal
    {
        List<SurveyOps> GetAll();

        SurveyOps Add(SurveyOps ops);
        
        SurveyOps Get(Expression<Func<SurveyOps, bool>>? filter = null);
        bool Delete(SurveyOps result);
        bool AddAnswer(int anketId, int soruId, int answerId);
    }
}
