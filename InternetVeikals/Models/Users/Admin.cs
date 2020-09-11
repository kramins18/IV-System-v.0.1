namespace InternetVeikals.Models.Users
{
    /// <summary>
    /// Administrators class
    /// </summary>
    /// <seealso cref="InternetVeikals.Models.Users.User" />
    public class Admin : User
    {
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// Value of salary.
        /// </value>
        public double Salary { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// And sets role to admin
        /// </summary>
        public Admin()
        {
            role = Role.Admin;
        }

    }
}