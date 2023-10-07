using System.ComponentModel.DataAnnotations;

namespace Bandaging.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Please give a headline to your blog")]
        public string Headline { get; set; }
        [Required(ErrorMessage = "Please provide a the written content")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please choose file to upload.")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload image")]
        public string ImagePath1 { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload optional image")]
        public string? ImagePath2 { get; set; }
        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; private set; } = DateTime.Now;
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = new();
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
    }
}
