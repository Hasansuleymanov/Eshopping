using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Picture
    {
        public int Id { get; set; }
        [MaxLength(700)]
        public string PhotoUrl { get; set; }
    }
}
