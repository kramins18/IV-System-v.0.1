using InternetVeikals.DTOs;
using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.UserService
{
    public interface IUserService
    {
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomers();
        Customer getCustomerByID(int id);
        void CreateCustomer(Customer model);
        void UpdateCustomer(Customer model);
        void DeleteCustomer(Customer model);
        Customer LogIn(CustomerLoginDTO creditentials);
    }
}
