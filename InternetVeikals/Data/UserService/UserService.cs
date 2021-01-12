using InternetVeikals.DTOs;
using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.UserService
{
    public class UserService : IUserService
    {

        private readonly Context _context;

        public UserService(Context context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Add(model);
        }

        public void DeleteCustomer(Customer model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(model);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer.ToList();
        }

        public Customer getCustomerByID(int id)
        {
            return _context.Customer.FirstOrDefault(x => x.Id == id);
        }

        public Customer LogIn(CustomerLoginDTO creditentials)
        {
            Customer cust = _context.Customer.FirstOrDefault(x => x.Username == creditentials.Login && x.Password == creditentials.Password);
            return cust;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCustomer(Customer model)
        {
            //
        }
    }
}
