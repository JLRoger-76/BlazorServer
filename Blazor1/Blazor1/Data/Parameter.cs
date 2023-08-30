using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor1.Data
{
    public class Parameter
    {
        public int CategoryId { get; set; }
        public int ProductsByPage { get; set; }
        public int Sort { get; set; }
        public int CurrentPage { get; set; }
        public string SearchTerm { get; set; }
        public int StockId { get; set; }
        public int SupplierId { get; set; }
        public Parameter(int categoryId, int productsByPage, int sort, int currentPage, string searchTerm, int stockId, int supplierId)
        {
            CategoryId = categoryId;
            ProductsByPage = productsByPage;
            Sort = sort;
            CurrentPage = currentPage;
            SearchTerm = searchTerm;
            StockId = stockId;
            SupplierId = supplierId;
        }
    }
}
