using System.ComponentModel.DataAnnotations;
namespace Learningcs.Models
{
    public class Category
    {
        // Key attribute is required to create a primary key
        // Display attribute is used to display a user-friendly name
        // Required attribute is used to make a field required
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Category Description")]
        public string Description { get; set; }
        [Display(Name = "Display Order for Category")]
        public int DisplayOrder { get; set; }
    }
}