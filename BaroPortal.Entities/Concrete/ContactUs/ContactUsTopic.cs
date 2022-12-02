using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.ContactUs
{
    public class ContactUsTopic : BaseEntity
    {

        public int? TopicId { get; set; }
        public string? Name { get; set; } = null;
        public virtual ICollection<ContactUs>? ContactUs { get; set; }
    }
}
