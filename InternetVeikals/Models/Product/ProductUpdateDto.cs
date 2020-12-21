using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Models.Product
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public long CategoryId { get; set; }
        public bool IsPublished { get; set; }
 
        public double Price { get; set; }
   
        public long AdminId { get; set; }
    
        //public ICollection<ProductImage> ProductImages { get; set; }
        //public ICollection<Order.OrderItem> OrderItems { get; set; }
        //public ICollection<Cart.CartProduct> CartProducts { get; set; }
    }
}
