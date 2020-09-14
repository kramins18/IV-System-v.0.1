using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetVeikals.Models.Cart
{
    /// <summary>
    /// Entity class for cart Products
    /// </summary>
    public class CartProduct
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
        public DateTime Created{ get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        [ForeignKey("Product")]
        public long ProductId{ get; set; }
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        public Product.Product Product { get; set; }
        /// <summary>
        /// Gets or sets the cart identifier.
        /// </summary>
        /// <value>
        /// The cart identifier.
        /// </value>
        [ForeignKey("Cart")]       
        public long CartId { get; set; }
        /// <summary>
        /// Gets or sets the cart.
        /// </summary>
        /// <value>
        /// The cart.
        /// </value>
        public Cart Cart { get; set; }
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }
    }
}