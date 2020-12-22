using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data
{
    public interface IProductImageService
    {
        bool SaveChanges();
        IEnumerable<ProductImage> GetAllImages();
        IEnumerable<ProductImage> GetProductImageByProductId(long productId);
        ProductImage GetImageById(int id);
        void CreateProductImage(ProductImage model);
        void DeleteProductImage(ProductImage model);
    }
}
