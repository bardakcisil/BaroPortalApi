using BaroPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete
{
    
    public class AdvType :BaseEntity
    {
        public int TypeId { get; set; }
        public string Name { get; set; } = null;
        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
