using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public class ProductImageService : IProductImageService
    {
        private readonly Context _context;

        public ProductImageService(Context context)
        {
            _context = context;
        }
        public void CreateProductImage(ProductImage model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Add(model);
        }

        public void DeleteProductImage(ProductImage model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }
            _context.Remove(model);
        }

        public IEnumerable<ProductImage> GetAllImages()
        {
            return _context.ProductImage.ToList();
        }

        public ProductImage GetImageById(int id)
        {
            return _context.ProductImage.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ProductImage> GetProductImageByProductId(long productId)
        {
            return _context.ProductImage.Where(p => p.ProductId == productId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
