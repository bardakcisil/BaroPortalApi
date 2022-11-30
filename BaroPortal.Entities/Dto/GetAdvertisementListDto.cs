using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.Entities.Dto
{
    public class GetAdvertisementListDto
    {
        public string? Advertiser { get; set; } = null!;
        public string? Title { get; set; } = null!;
        public string? AdvertiserPhone { get; set; } = null!;
        public string? AdvertiserEmail { get; set; } = null!;
        public string? Description { get; set; } = null!;


    }
}
