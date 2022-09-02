using System.ComponentModel.DataAnnotations;

namespace ClothingShopManagement.Models
{
    public class BillDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BillId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
