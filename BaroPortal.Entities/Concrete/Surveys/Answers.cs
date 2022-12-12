using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Surveys
{
    public class Answers:BaseEntity
    {
        public int? AnswerId;
        public string? AnswerName;
        public ICollection<Questions>? Question { get; set; } 
        public ICollection<SurveyOps>? SurveyOp { get; set; }
    }
}
