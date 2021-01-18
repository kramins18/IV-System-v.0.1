using InternetVeikals.DTOs;
using InternetVeikals.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public interface IOrderService
    {
        Order CreateOrder(CreateOrderDTO order);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> UpdateOrderStatus(string status, long id);

    }
}
