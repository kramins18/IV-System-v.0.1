using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.CategoryService
{
      public interface ICategoryService
       {
           bool SaveChanges();
           IEnumerable<Category> GetAllCategories();
           Category GetCategoryByID(int id);
           void CreateCategory(Category model);
           void UpdateCategory(Category model);
           void DeleteCategory(Category model);
       }
}
