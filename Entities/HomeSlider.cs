using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HomeSlider
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string? Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [MaxLength(600)]
        public string? PhotoUrl { get; set; }
        [MaxLength(600)]
        public string? Url { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNew { get; set; }
        public string? TextPosition { get; set; }
    }
}
