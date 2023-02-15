using Entities;

namespace WebMVC.Areas.Admin.Models
{
    public class CategoryListVM
    {
        public List<Category> Categories { get; set; }
        public int Total;
    }
}
