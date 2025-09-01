using System.ComponentModel.DataAnnotations;

namespace Catalog.Domain.Entities
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(400)]
        public string Url { get; set; }

        [MaxLength(150)]
        public string? AltText { get; set; }

        [Required]
        public int SortOrder { get; set; } = 0;

        // Navigation property
        public Product? Product { get; set; }
    }
}