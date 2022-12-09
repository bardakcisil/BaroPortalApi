using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete
{
    public class Court:BaseEntity
    {
        public int? TypeId { get; set; }
        public string? Name { get; set; } = null;
    }
}
