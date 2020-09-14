using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetVeikals.Models.Cart
{
    /// <summary>
    /// Entity class of cart
    /// </summary>
    public class Cart: BaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public Customer Customer { get; set; }
        /// <summary>
        /// Gets or sets the cart products.
        /// </summary>
        /// <value>
        /// The cart products.
        /// </value>
        public ICollection<CartProduct> CartProducts { get; set; }

    }
}