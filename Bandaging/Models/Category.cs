using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bandaging.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name ="Category")]
        public string CategoryName { get; set; }
        public List<SubCategory> SubCategories { get; } = new();
        public List<Category> Categories { get; } = new();
    }
}
