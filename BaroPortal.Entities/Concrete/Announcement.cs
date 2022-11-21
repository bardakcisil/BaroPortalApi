using BaroPortal.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete
{
    public class Announcement : BaseEntity
    {
        public byte[] ImageData { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Detail { get; set; } = null!;
    }
}
