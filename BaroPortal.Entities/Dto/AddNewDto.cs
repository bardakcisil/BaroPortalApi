using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class AddNewDto
    {
        public string Title { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public byte[] image { get; set; } = null!;
    }
}
