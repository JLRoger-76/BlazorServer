using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime SaleDate { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }
    }
}
