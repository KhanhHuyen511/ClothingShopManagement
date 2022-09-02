using System.ComponentModel.DataAnnotations;

namespace ClothingShopManagement.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; } = null!;

        public double TotalPrice { get; set; } = 0;

        public BillStatus BillStatus { get; set; } = BillStatus.DELIVERING;
    }

    public enum BillStatus
    {
        DELIVERING,
        COMPLETED
    }
}
