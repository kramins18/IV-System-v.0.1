using AutoMapper;
using InternetVeikals.Data.ProductService;
using InternetVeikals.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Controllers
{
    [Route("/api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _repo;
        private readonly IMapper _mapper;
      

        public ProductController(IProductService repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            IEnumerable<Product> Products = _repo.GetAllProducts();
            return Ok(_mapper.Map<IEnumerable<Product>>(Products));
        }

        [HttpGet("{id}", Name = "GetProductByID")]
        public ActionResult<Product> GetProductByID(int id)
        {
            Product product = _repo.GetProductByID(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Product>(product));
        }


        //[HttpPost]
        //public ActionResult<ApartmentReadDTO> CreateApartment(ApartmentCreateDTO model)
        //{
        //    var apartmentModel = _mapper.Map<ApartmentModel>(model);
        //    if (_houseRepo.GetHouseById(apartmentModel.ID_House) == null)
        //    {
        //        return BadRequest($"House With ID {model.ID_House} was not found \n Use https://localhost:44359/api/houses from list of avalibale houses! ");
        //    }
        //    _repo.CreateApartment(apartmentModel);
        //    _repo.SaveChanges();
        //    var apartmentReadDTO = _mapper.Map<ApartmentReadDTO>(apartmentModel);
        //    return CreatedAtRoute(nameof(GetApartmentByID), new { ID = apartmentReadDTO.ID_Apartment }, apartmentReadDTO);

        //}

    }
}
