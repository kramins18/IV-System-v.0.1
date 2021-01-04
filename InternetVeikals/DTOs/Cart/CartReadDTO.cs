using InternetVeikals.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.DTOs.Cart
{
    public class CartReadDTO
    {

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long CustomerId { get; set; }
        public ICollection<CartProduct> CartProducts { get; set; }
    }
}
