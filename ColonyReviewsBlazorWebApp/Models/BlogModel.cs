using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ColonyReviewsBlazorWebApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }
        [StringLength(150)]
        public string? Title { get; set; }
        [StringLength(3000)]
        [DataType(DataType.MultilineText)]
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
        [StringLength(100)]
        public string? Author { get; set; }
    }
}
