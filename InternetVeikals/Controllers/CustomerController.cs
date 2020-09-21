using InternetVeikals.Data;
using InternetVeikals.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;


namespace InternetVeikals.Controllers
{
    [Route("/api/Customer")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private CustomerService CustomerService { get; set; }
        public CustomerController(IServiceProvider service) : base(service)
        {
            CustomerService = service.GetService<CustomerService>();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var a = await CustomerService.GetAll();
            return Ok(a);
        }





    }
}