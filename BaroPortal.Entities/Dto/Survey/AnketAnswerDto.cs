
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Survey
{
    public class AnketAnswerDto
    {
        
        public int Id { get; set; }
        public int SurveyId { get; set; }
        //public int AnswerId { get; set; }
        public List<ListSoruDto> GetAnswerFromListSoru{ get; set; }
    }
}
