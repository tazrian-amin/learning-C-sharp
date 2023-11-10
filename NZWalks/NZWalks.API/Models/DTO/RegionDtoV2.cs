namespace NZWalks.API.Models.DTO
{
    public class RegionDtoV2
    {
        public Guid Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
