using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor1.Data
{
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductId { get; set; }
        // Foreign Key
        public int SupplierId { get; set; }
        // Foreign Key
        public int ProductId { get; set; }
        // Navigation property
        public Supplier Supplier { get; set; }
        // Navigation property
        public Product Product { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
