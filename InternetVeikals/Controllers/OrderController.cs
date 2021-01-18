using AutoMapper;
using InternetVeikals.Data;
using InternetVeikals.DTOs;
using InternetVeikals.Models.Order;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Controllers
{
    [Route("/api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IOrderService _repo;
        public OrderController(IOrderService repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpPost]
        public ActionResult<Order> CreateOrder(CreateOrderDTO a)
        {
            var x = _repo.CreateOrder(a);
            return Ok(x);
        }

        //[HttpPost("{id}/Orders", Name = "UpdateCart")]
        //public ActionResult<Order> CreateOrder(int id)
        //{
        //    var a = new CreateOrderDTO();
        //    a.DeliveryAddress = "delivery address";
        //    a.CustomerId = 10002;
        //    a.CartId = 10004;
        //    a.TotalSum = 123.32;
        //    var x = _repo.CreateOrder(a);
        //    return Ok(x);
        //}

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllCategories()
        {
            IEnumerable<Order> orders = _repo.GetAllOrders();
            return Ok(orders);
        }

        [HttpPost]
        [Route("/api/order/status")]
        public ActionResult<IEnumerable<Order>> UpdateStatus(UpdtOrd dto)
        {
            IEnumerable<Order> orders = _repo.UpdateOrderStatus(dto.Status, dto.Id);
            return Ok(orders);
        }

    }
}
