using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Areas.Admin.Models
{
    public class CategoryCreateVM
    {
        [DisplayName("Category Name")]
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
    }
}
