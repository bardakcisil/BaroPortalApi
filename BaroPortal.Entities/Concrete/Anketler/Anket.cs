using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Anketler
{
    public class Anket : BaseEntity
    {
        public int? SurveyId { get; set; }
        public string? SurveyName { get; set; }
        public IList<Soru>? Question { get; set; }
    }
}
