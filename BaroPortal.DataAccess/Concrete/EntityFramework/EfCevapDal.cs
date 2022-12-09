using BaroPortal.DataAccess.Abstract;
using BaroPortal.DataAccess.Concrete.EntityFramework.Context;
using BaroPortal.Entities.Concrete.Surveys;

namespace BaroPortal.DataAccess.Concrete.EntityFramework
{
    public class EfCevapDal:ICevapDal
    {
        public List<Answers> GetDetail()
        {
            var context = new AppDbContext();
            var result = context.Answers.ToList();
            return result;
        }
    }
}
