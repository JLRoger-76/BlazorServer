using System.ComponentModel.DataAnnotations;


namespace Blazor1.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(55)]
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
