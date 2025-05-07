using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FNBapp.Data
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }= string.Empty;
        [Range(0.01, 1000)]
        [Column(TypeName = "decimal(18,2)")]  // Προσθήκη αυτής της γραμμής
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? SpecialTag { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

    }
}
