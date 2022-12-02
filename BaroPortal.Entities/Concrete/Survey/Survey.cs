using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Survey
{
    public class Survey : BaseEntity
    {
        public int? SurveyId { get; set; }   
        public string? SurveyName { get; set; }  
        public List<Question>? Question { get; set; }
    }
}
