using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Models.Product
{
    public class ProductReadDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductImage> productImages{ get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsPublished { get; set; }
        public double Price { get; set; }
        public long AdminId { get; set; }

    }


}
