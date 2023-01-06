using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.ListDto
{
    public class ListResultDto<T>
    {
        public List<T> Data { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
    }
}
