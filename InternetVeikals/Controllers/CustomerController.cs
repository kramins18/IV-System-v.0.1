using InternetVeikals.Data;
using InternetVeikals.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InternetVeikals.Data.UserService;
using InternetVeikals.DTOs;

namespace InternetVeikals.Controllers
{
    [Route("/api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUserService _repo;
        private readonly IMapper _mapper;


        public CustomerController(IUserService repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            IEnumerable<Customer> customers = _repo.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            Customer customer = _repo.getCustomerByID(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var modelFromRepo = _repo.getCustomerByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteCustomer(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public ActionResult<Customer> CreateCustomer(Customer model)
        {
            _repo.CreateCustomer(model);
            _repo.SaveChanges();

            var customer = _mapper.Map<Customer>(model);
            return CreatedAtRoute(nameof(GetCustomerById), new { ID = customer.Id }, customer);

        }

        [HttpPost]
        [Route("/api/customer/login")]
        public ActionResult<Customer> LogIn(CustomerLoginDTO cred)
        {
            var cust = _repo.LogIn(cred);
            if (cust == null)
            {
                return NotFound();
            }

            return Ok(cust);

        }


        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, Customer model)
        {
            var modelFromRepo = _repo.getCustomerByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(model, modelFromRepo);
            _repo.UpdateCustomer(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }
    }
}