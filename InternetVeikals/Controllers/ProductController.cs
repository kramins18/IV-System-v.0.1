using AutoMapper;
using InternetVeikals.Data.CategoryService;
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
        private readonly ICategoryService _repoCategory;
        private readonly IMapper _mapper;
      

        public ProductController(IProductService repo, IMapper mapper, ICategoryService repoCategory)
        {
            _repo = repo;
            _repoCategory = repoCategory;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            IEnumerable<Product> Products = _repo.GetAllProducts();
            IEnumerable<Category> categories = _repoCategory.GetAllCategories();


            var productsList = _mapper.Map<IEnumerable<ProductReadDto>>(Products);
            foreach (var product in productsList)
            {
                product.CategoryName = categories.FirstOrDefault(x => x.Id == product.CategoryId).Name;
            }



            return Ok(productsList);
        }

        [HttpGet("{id}", Name = "GetProductByID")]
        public ActionResult<Product> GetProductByID(int id)
        {
            Product product = _repo.GetProductByID(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Category> CreateProduct(Product model)
        {
            _repo.CreateProduct(model);
            _repo.SaveChanges();

            var product = _mapper.Map<Product>(model);
            return CreatedAtRoute(nameof(GetProductByID), new { ID = product.Id }, product);

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var modelFromRepo = _repo.GetProductByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteProduct(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }


        [HttpPut("{id}")]
        public ActionResult UpdateHouse(int id, ProductUpdateDto model)
        {
            var modelFromRepo = _repo.GetProductByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(model, modelFromRepo);
            _repo.UpdateProduct(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }




    }
}
