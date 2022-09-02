using System.ComponentModel.DataAnnotations;

namespace ClothingShopManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        public int RemainQuantity { get; set; } = 0;

        [Required]
        public double Price { get; set; } = 0;

        public string Description { get; set; } = null!;

        public int Image { get; set; }

    }
}
