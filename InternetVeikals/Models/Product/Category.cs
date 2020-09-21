using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternetVeikals.Models.Product
{
    /// <summary>
    /// Class contains all common categories for products
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name of Category.
        /// </summary>
        /// <value>
        /// The name of Category.
        /// </value>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public ICollection<Product> Products { get; set; }
    }
}
