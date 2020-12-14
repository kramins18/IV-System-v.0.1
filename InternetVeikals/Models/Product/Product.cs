using InternetVeikals.Models.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetVeikals.Models.Product
{
    /// <summary>
    /// Product class hold all common propererties of product
    /// </summary>
    public class Product
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the name of Product.
        /// </summary>
        /// <value>
        /// The name of Product.
        /// </value>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the description of Product.
        /// </summary>
        /// <value>
        /// The description of Product.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the img URL of Product.
        /// </summary>
        /// <value>
        /// The img URL of Product.
        /// </value>
        public string ImgUrl { get; set; }
        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        [ForeignKey("Category")]
        [Required]
        public long CategoryId { get; set; }
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public Category Category { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is published.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is published; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsPublished { get; set; }
        /// <summary>
        /// Gets or sets the price of Product.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [Required]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the  FK admin identifier.
        /// </summary>
        /// <value>
        /// The admin identifier.
        /// </value>
        [ForeignKey("Admin")]
        [Required]
        public long AdminId { get; set; }
        /// <summary>
        /// Gets or sets the admin.
        /// </summary>
        /// <value>
        /// The admin.
        /// </value>
        public Admin Admin { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Order.OrderItem> OrderItems { get; set; }
        public ICollection<Cart.CartProduct> CartProducts { get; set; }
    }
}