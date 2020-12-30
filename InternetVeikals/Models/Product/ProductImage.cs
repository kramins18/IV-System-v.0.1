using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InternetVeikals.Models.Product
{
    /// <summary>
    /// Class stores product image adresses by product
    /// </summary>
    public class ProductImage
    {
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the img URL.
        /// </summary>
        /// <value>
        /// The img URL.
        /// </value>
        public string ImgUrl { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        [ForeignKey("Product")]
        public long? ProductId { get; set; }
        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        [JsonIgnore]
        public Product Product { get; set; }
    }
}