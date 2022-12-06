using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Survey
{
    public class GetQuestionListDto
    {
        public int? QuestionId { get; set; }    
        public string? QuestionTitle { get; set; } = null!;
        public string? QuestionDetail { get; set; } = null!;
        

    }
}
