using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(5, ErrorMessage ="The Code must have 5 characters")]
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
