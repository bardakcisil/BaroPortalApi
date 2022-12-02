using BaroPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Concrete.ContactUs
{
    public class ContactUs : BaseEntity
    {
        public string? Name { get; set; } = null!;
        public string? Surname { get; set; } = null!;
        public string? Email { get; set; } = null!;
        public string? Message { get; set; } = null!;
        public int? TopicId { get; set; }
        public ContactUsTopic? ContactUsTopic { get; set; }
    }
}
