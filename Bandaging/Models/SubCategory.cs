using System.ComponentModel.DataAnnotations;

namespace Bandaging.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Display(Name = "Sub category")]
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
        public List<Blog> Blogs { get; } = new();
    }
}
