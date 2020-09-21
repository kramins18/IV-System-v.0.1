using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InternetVeikals.Data;
using InternetVeikals.DTOs.Admin;
using InternetVeikals.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace InternetVeikals.Controllers
{
    [Route("/api/admin")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly AdminService _repo;
        private readonly IMapper _mapper;

        public AdminController(AdminService ctx, IMapper mapper)
        {
            _repo = ctx;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Admin>> GetAllHouses()
        {
            IEnumerable<Admin> admin = _repo.GetAllResidents();
            return Ok(_mapper.Map<IEnumerable<AdminDTO>>(admin));
        }
    }
}