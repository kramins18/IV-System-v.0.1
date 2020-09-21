using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InternetVeikals.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        public BaseController(IServiceProvider services)
        {
            _mapper = services.GetRequiredService<IMapper>();
        }
    }
}
