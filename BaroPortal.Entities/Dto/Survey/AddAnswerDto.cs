using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Survey
{
    public class AddAnswerDto
    {
        public int? SurveyId { get; set; }
        public int? AnswerId { get; set; }
        public int? QuestionId { get; set; }
    }
}
