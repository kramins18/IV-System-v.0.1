using AutoMapper;
using InternetVeikals.Data.CategoryService;
using InternetVeikals.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Controllers
{
    [Route("/api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _repo;
        private readonly IMapper _mapper;


        public CategoryController(ICategoryService repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategories()
        {
            IEnumerable<Category> categories = _repo.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<Category>>(categories));
        }

        [HttpGet("{id}", Name = "GetCategoryById")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            Category category = _repo.GetCategoryByID(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Category>(category));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var modelFromRepo = _repo.GetCategoryByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _repo.DeleteCategory(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public ActionResult<Category> CreateCategory(Category model)
        {
            _repo.CreateCategory(model);
            _repo.SaveChanges();

            var category = _mapper.Map<Category>(model);
            return CreatedAtRoute(nameof(GetCategoryById), new { ID = category.Id }, category);

        }

        [HttpPut("{id}")]
        public ActionResult UpdateHouse(int id, CategoryUpdateDto model)
        {
            var modelFromRepo = _repo.GetCategoryByID(id);
            if (modelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(model, modelFromRepo);
            _repo.UpdateCategory(modelFromRepo);
            _repo.SaveChanges();
            return NoContent();
        }
    }
}
