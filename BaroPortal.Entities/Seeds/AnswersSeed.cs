using BaroPortal.Entities.Concrete.Surveys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Seeds
{
    public static class AnswersSeed
    {
        public static readonly List<Answers> answer = new List<Answers>()
    {

             new   Answers() { Id =1, AnswerId = 1, AnswerName = "Strongly Disagree", CreateDate=DateTime.Now },
            new    Answers() { Id = 2, AnswerId = 2, AnswerName = "Disagree", CreateDate = DateTime.Now },
             new   Answers() { Id = 3, AnswerId = 3, AnswerName = "Neutral", CreateDate = DateTime.Now },
             new   Answers() { Id = 4, AnswerId = 4, AnswerName = "Agree", CreateDate = DateTime.Now },
             new   Answers() { Id = 5, AnswerId = 5, AnswerName = "Strongly Agree", CreateDate = DateTime.Now },


    };
    }
}
