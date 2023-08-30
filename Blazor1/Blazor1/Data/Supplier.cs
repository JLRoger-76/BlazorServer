using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Blazor1.Data
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}
