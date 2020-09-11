namespace InternetVeikals.Models.Product
{
    /// <summary>
    /// Class contains all common categories for products
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the identifier of Category.
        /// </summary>
        /// <value>
        /// The identifier of Category.
        /// </value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the name of Category.
        /// </summary>
        /// <value>
        /// The name of Category.
        /// </value>
        public string Name { get; set; }
    }
}
