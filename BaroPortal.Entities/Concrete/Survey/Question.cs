using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Survey
{
    public class Question : BaseEntity
    {
        public int? QuestionId { get; set; } 
        public string? QuestionTitle { get; set; }
        public string? QuestionDetail { get; set; } 
        public int? AnswerId { get; set; }
        public Answer? Answer { get; set; }
        public virtual ICollection<Survey>? Survey { get; set; }
    }
}
