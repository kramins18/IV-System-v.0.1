namespace InternetVeikals.Models.Users
{
    /// <summary>
    /// Customer Class contains properties for all ecomerce customers
    /// </summary>
    /// <seealso cref="InternetVeikals.Models.Users.User" />
    public class Customer: User
    {
        /// <summary>
        /// Gets or sets the delivery address of customer.
        /// </summary>
        /// <value>
        /// The customers delivery address.
        /// </value>
        public string DeliveryAddress { get; set; }
        /// <summary>
        /// Gets or sets the discount level of customer.
        /// </summary>
        /// <value>
        /// The discount level of customer.
        /// </value>
        public int DiscountLevel  { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class. Sets customer role.
        /// </summary>
        public Customer()
        {
            role = Role.Customer;
        }
    }
}