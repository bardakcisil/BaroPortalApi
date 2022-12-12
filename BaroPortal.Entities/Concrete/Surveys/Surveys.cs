using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Surveys
{
    public class Surveys : BaseEntity
    {
        public int? SurveyId { get; set; }
        public string? SurveyName { get; set; }
        public ICollection<Questions>? Question { get; set; }
        public ICollection<SurveyOps>? SurveyOp { get; set; }

    }
}
