using AutoMapper;
using InternetVeikals.DTOs;
using InternetVeikals.Models.Order;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public class OrderService : IOrderService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public OrderService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Order CreateOrder(CreateOrderDTO order)
        {
            var cart = _context.Cart
                .Include(x => x.CartProducts )
                .FirstOrDefault(x => x.Id == order.CartId);

            var orderToCreate = CreateEmptyOrder(order);

            foreach (var item in cart.CartProducts)
            {
                var orderItem = new OrderItem
                {
                    OrderId = orderToCreate.Id,
                    Amount = item.Amount,
                    ProductId = item.ProductId
                };
                _context.Add(orderItem);
            }

            _context.SaveChanges();

            var orderToReturn = _context.Order
                .Include(x => x.Customer)
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.ProductImages)
                .FirstOrDefault(x => x.Id == orderToCreate.Id);         
            return orderToReturn;

        }
        private Order CreateEmptyOrder(CreateOrderDTO order)
        {
            var orderToCreate = new Order
            {
                CustomerId = order.CustomerId,
                DeliveryAddress = order.DeliveryAddress,
                TotalSum = order.TotalSum
            };
         
            _context.Add(orderToCreate);
            _context.SaveChanges();

            return orderToCreate;
        }
    }
}
