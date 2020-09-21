﻿using InternetVeikals.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public class CustomerService : BaseService<Customer>
    {
        public CustomerService(IServiceProvider services) : base(services)
        {
            
        }
    }
}
