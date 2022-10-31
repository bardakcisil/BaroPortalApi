using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete
{
    public class Bulletin : BaseEntity
    {
            
        public string Title { get; set; } = null!;
        public string Detail { get; set; } = null!;
        // string  BultenImage { get; set; } = null!;

    }
}