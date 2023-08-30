using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blazor1.Data
{
    public class StockProduct
    {
        [Key]
        public int StockProductId { get; set; }
        // Foreign Key
        public int StockId { get; set; }
        // Foreign Key
        public int ProductId { get; set; }
        // Navigation property
        public Stock Stock { get; set; }
        // Navigation property
        public Product Product { get; set; }
        public int StockQuantity { get; set; }
        public int StockQuery { get; set; }
        [NotMapped]
        public int ParentStockProductId { get; set; }
        [NotMapped]
        public int ParentStockQuantity { get; set; }
        [NotMapped]
        public int ParentStockDelivery { get; set; }
        [NotMapped]
        public int StockEntry { get; set; }
    }
}

