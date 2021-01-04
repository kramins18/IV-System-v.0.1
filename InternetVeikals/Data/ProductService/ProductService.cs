using InternetVeikals.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.ProductService
{
    public class ProductService : IProductService
    {
        private readonly Context _context;
        public ProductService(Context context)
        {
            _context = context;
        }

        public void CreateProduct(Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Add(model);
        }

        public void DeleteProduct(Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(model);
        }

        public IEnumerable<Product> GetAllProducts()
       
        {
            var x = _context.Product.Include(x => x.ProductImages).ToList();
            return x;
        }

        public IEnumerable<Product> GetAllProductsByGroupId(int id)
        {
            var x = _context.Product.Where(p => p.CategoryId == id).ToList();
            return x;
        }

        public Product GetProductByID(int id)
        {
            return _context.Product.Include("ProductImages").FirstOrDefault(p => p.Id == id);

            //return _context.Product.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(Product model)
        {
            //
        }
    }
}
