using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Survey
{
    public class SoruDto
    {
        public int? Id { get; set; }
        public int? QuestionId { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionDetail { get; set; }
        public int? AnswerId { get; set; }
        public int? SurveyId { get; set; }
    }
}
