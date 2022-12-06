using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.Anketler
{
    public class Soru : BaseEntity
    {
        public int? QuestionId { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionDetail { get; set; }
        public int? AnswerId { get; set; }
        public Cevap? Answer { get; set; }
        public int? SurveyId { get; set; }
        public Anket? Survey { get; set; }
    }
}
