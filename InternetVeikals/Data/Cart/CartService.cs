using AutoMapper;
using InternetVeikals.DTOs.Cart;
using InternetVeikals.Models.Cart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.CartService
{
    public class CartService : ICartService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public CartService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CartReadDTO GetCartByID(int id)
        {
            if (id == 0)
                return CreateNewCart();
            var cart = _context.Cart
                .Include(x => x.CartProducts)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.ProductImages)
                .FirstOrDefault(a => a.Id == id);
            return _mapper.Map<CartReadDTO>(cart);
        }
        private CartReadDTO CreateNewCart()
        {
            Cart cart = new Cart();
            _context.Add(cart);
            SaveChanges();
            return _mapper.Map<CartReadDTO>(cart);
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public CartReadDTO UpdateCart(int id, string action, int productId)
        {
            var cart = _context.Cart.Include(x=>x.CartProducts).ThenInclude(x => x.Product).ThenInclude(x => x.ProductImages).FirstOrDefault(c => c.Id ==id);
            var product = cart.CartProducts.FirstOrDefault(x => x.ProductId == productId);


            if (product != null && action == "delete")
            {
                if(product.Amount == 1)
                {
                    cart.CartProducts.Remove(product);
                }
                else
                {
                    product.Amount --;
                }

                SaveChanges();
            }

            if(action == "add")
            {
                if(product == null)
                {
                    var prod = new CartProduct();
                    prod.Created = DateTime.Now;
                    prod.CartId = id;
                    prod.ProductId = productId;
                    prod.Amount = 1;
                    cart.CartProducts.Add(prod);
                }
                else
                {
                    product.Amount++;
                }
                SaveChanges();
            }

            return _mapper.Map<CartReadDTO>(cart);

        }

    }

}

