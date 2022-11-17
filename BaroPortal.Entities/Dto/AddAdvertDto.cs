using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class AddAdvertDto
    {
        public int AdvertId { get; set; }

        public string AdvertTypeName { get; set; } = null;
        public string Title { get; set; } = null!;

        public string AdvertiserName { get; set; } = null!;

        public string AdvertiserSname { get; set; } = null!;

        public string AdvertiserPhone { get; set; } = null!;

        public string AdvertiserEmail { get; set; } = null!;

        public string AdvertiserLwork { get; set; } = null!;
        public string Conscription { get; set; } = null!;
        public string Detail { get; set; } = null!;
    }
}
