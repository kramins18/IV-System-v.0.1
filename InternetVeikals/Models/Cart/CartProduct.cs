using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InternetVeikals.Models.Cart
{
    /// <summary>
    /// Entity class for cart Products
    /// </summary>
    public class CartProduct
    {
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
        [Required]
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
        [Required]
        public long CartId { get; set; }
        /// <summary>
        /// Gets or sets the cart.
        /// </summary>
        /// <value>
        /// The cart.
        /// </value>
        [JsonIgnore]
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