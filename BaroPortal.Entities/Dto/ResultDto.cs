using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class ResultDto
    {
        //public string? Data { get; set; } = null!;
        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
    }
}
