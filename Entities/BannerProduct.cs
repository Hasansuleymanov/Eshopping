using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BannerProduct
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string? Title { get; set; }
        [MaxLength(600)]
        public string? Description { get; set; }
        [MaxLength(600)]
        public string? PhotoUrl { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get;set; }
    }
}
