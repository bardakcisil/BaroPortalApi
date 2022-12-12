using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Surveys
{
    public class Questions : BaseEntity
    {
            
        public int? QuestionId { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionDetail { get; set; }
        public int? AnswerId { get; set; }
        public Answers? Answer { get; set; }
        public int? SurveyId { get; set; }
        public Surveys? Survey { get; set; }
        public ICollection<SurveyOps>? SurveyOp { get; set; }

    }
}
