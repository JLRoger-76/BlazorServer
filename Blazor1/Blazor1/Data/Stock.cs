using System.ComponentModel.DataAnnotations;


namespace Blazor1.Data
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public string StockName { get; set; }
    }
}
