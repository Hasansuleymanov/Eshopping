using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; } = null!;
        [MaxLength(1500)]
        public string Description { get; set; } = null!;
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        [MaxLength(800)]
        public int InStock { get; set; }
        public int CoverPhotoId { get; set; }
        public bool IsNew { get; set; }
        public bool IsHot { get; set; }
        public bool IsFeatured { get; set; }
        public decimal Cost { get; set; }
        public bool IsDeleted { get; set; }
        public string? Manifacture { get; set; }
        public virtual List<ProductToPicture> ProductToPictures { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? Modifiedt { get; set; }
    }
}
