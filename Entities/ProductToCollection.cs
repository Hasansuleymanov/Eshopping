using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductToCollection
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CollectionId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Collection? Collection { get; set; }
    }
}
