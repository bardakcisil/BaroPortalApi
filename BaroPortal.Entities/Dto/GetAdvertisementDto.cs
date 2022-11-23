namespace BaroPortal.Entities.Dto
{
    public class GetAdvertisementDto
    {
        public int AdvertId { get; set; }
        public string Advertiser { get; set; } = null!;
        public string AdvertiserPhone { get; set; } = null!;
        public string AdvertiserEmail { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? TypeId { get; set; }

        public string Name { get; set; } = null!;

    }
}
