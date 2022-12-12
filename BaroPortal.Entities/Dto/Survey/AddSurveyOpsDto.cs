using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Survey
{
    public class AddSurveyOpsDto
    {
        public int SurveyId { get; set; }   
        public List<ListSoruDto> GetAnswerFromListSoru { get; set; }
    }
}
