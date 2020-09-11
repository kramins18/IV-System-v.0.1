using System.ComponentModel.DataAnnotations;

namespace InternetVeikals.Models.Users
{
    /// <summary>
    /// Abstract class of users. This class holds common properties of users like id, name.. and other
    /// This class is ment to be inharitaded from when creating Admins, customers,
    /// and all other kind of users there might be. 
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// Identifier os user class
        /// </value>
        [Key]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the name of user Full name.
        /// </summary>
        /// <value>
        /// Users full name
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the surname of user.
        /// </summary>
        /// <value>
        /// Users surename.
        /// </value>
        public string Surname { get; set; }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// Users username.
        /// </value>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the personal no.
        /// </summary>
        /// <value>
        /// The personal no or identifier
        /// </value>
        public string PersonalNo { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password of user.
        /// </value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role to determen rights.
        /// </value>
        public Role role { get; set; }
    }
    /// <summary>
    /// Roles of all users
    /// </summary>
    public enum Role
    {
        SuperUser, // Have All Rights
        Admin,  // Can add products
        Customer
    }
}