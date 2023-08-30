using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor1.Data
{
    public class SaleProduct
    {
        [Key]
        public int SaleProductId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [NotMapped]
        public int ToStock { get; set; }
        public int InStock { get; set; }

        // Foreign Key
        public int ProductId { get; set; }
        // Foreign Key
        public int SaleId { get; set; }
        // Navigation property
        public Sale Sale { get; set; }
        // Navigation property
        public Product Product { get; set; }
    }
}
