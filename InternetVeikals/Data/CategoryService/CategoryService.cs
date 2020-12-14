using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly Context _context;
        public CategoryService(Context context)
        {
            _context = context;
        }

        public void CreateCategory(Category model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Add(model);
        }

        public void DeleteCategory(Category model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(model);
        }

        public IEnumerable<Category> GetAllCategories()
        {
           return _context.Category.ToList();
        }

        public Category GetCategoryByID(int id)
        {
            return _context.Category.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCategory(Category model)
        {
            //
        }
    }
}
