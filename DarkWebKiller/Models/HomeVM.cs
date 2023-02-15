using Entities;

namespace DarkWebKiller.Models
{
    public class HomeVM
    {
        public List<HomeSlider>? HomeSliders { get; set; }
        public List<Product>? FeaturedProducts { get; set; }
        public List<Product>?TopSellingProducts { get; set; }
        public List<Collection>? Collections { get; set; }
        public List<BannerProduct>? BannerProducts { get; set; }
    }
}
