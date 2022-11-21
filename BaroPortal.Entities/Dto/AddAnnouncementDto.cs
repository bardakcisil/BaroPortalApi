using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class AddAnnouncementDto
    {
        public byte[] ImageData { get; set; }
        public string Title { get; set; } = null!;
        public string Detail { get; set; } = null!;
    }
}
