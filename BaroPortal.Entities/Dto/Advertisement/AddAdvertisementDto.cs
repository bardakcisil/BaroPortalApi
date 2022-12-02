using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto.Advertisement
{
    public class AddAdvertisementDto
    {


        public string? Advertiser { get; set; } = null!;
        public string? AdvertiserPhone { get; set; } = null!;
        public string? AdvertiserEmail { get; set; } = null!;
        public string? Title { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int? TypeId { get; set; }

    }
}
