using System.ComponentModel.DataAnnotations;

namespace ValidateOptionDemo
{
    public class DomainSiteDemo
    {
        public const string SectionName = "DomainSite";

        [Required,Url]
        public string? SiteUrl { get; set; }

        [Required]
        public string? AdminUser { get; set; }

        [Required, Range(1, 90)]
        public int? Timeout { get; set; }

    }
}
