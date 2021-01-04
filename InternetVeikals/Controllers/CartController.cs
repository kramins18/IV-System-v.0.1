using AutoMapper;
using InternetVeikals.Data.CartService;
using InternetVeikals.Data.CategoryService;
using InternetVeikals.DTOs.Cart;
using InternetVeikals.Models.Cart;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Controllers
{
    [Route("/api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICartService _repo;


        public CartController(ICartService repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet("{id}", Name = "GetCartById")]
        public ActionResult<CartReadDTO> GetCartById(int id)
        {
            var cart = _repo.GetCartByID(id);
            return Ok(cart);
        }

        [HttpPost("{id}/update", Name = "UpdateCart")]
        public ActionResult<CartReadDTO> UpdateCart(int id, string action, int productId)
        {
            var cart = _repo.UpdateCart(id,action,productId);


            return Ok(cart);
        }

    }
    

}
