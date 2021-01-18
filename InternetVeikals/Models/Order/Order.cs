using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetVeikals.Models.Order
{
    /// <summary>
    /// Model of order
    /// </summary>
    public class Order
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the date of creation.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public DateTime Created{ get; set; }
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [ForeignKey("Customer")]
        [Required]
        public long CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        
        public Customer Customer { get; set; }
        /// <summary>
        /// Gets or sets the delivery address.
        /// </summary>
        /// <value>
        /// The delivery address.
        /// </value>
        public string DeliveryAddress{ get; set; }
        /// <summary>
        /// Gets or sets the total sum.
        /// </summary>
        /// <value>
        /// The total sum.
        /// </value>
        public double TotalSum { get; set; }
        /// <summary>
        /// Gets or sets the order items.
        /// </summary>
        /// <value>
        /// The order items.
        /// </value>
        public ICollection<OrderItem> OrderItems { get; set; }
        public string Status { get; set; }
    }
}