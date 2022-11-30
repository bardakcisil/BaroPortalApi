using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class GetBarSearchListDto
    {
        public string? Name { get; set; } = null!;
        public string? Surname { get; set; } = null!;
        public int? title { get; set; } = null!;
        public int? BarNumber { get; set; } = null!;
      
    }
}