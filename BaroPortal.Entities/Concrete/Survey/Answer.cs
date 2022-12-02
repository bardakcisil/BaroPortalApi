using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Survey
{
    public class Answer : BaseEntity
    {
       public int? AnswerId;
       public string? AnswerName;
        public virtual ICollection<Question> Question { get; set; }
    }
}
