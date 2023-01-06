using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.BarSearch
{
    public class LawyerResponseDto
    {
        public bool HasError { get; set; }


        public List<GetBarSearchListDto> Data { get; set; }
    }
}