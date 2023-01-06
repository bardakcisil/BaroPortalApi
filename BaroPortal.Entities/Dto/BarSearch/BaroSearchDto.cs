using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.BarSearch
{
    public class BaroSearchDto
    {
        public int? TypeId { get; set; }
        public int? BaroNumber { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
