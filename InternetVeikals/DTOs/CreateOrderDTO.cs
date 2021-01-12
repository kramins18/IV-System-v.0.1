using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.DTOs
{
    public class CreateOrderDTO
    {
        public DateTime Created { get; set; }
        public long CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        public long CartId { get; set; }
        public double TotalSum { get; set; }
    }
}
