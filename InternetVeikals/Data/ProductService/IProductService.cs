using InternetVeikals.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.ProductService
{
    public interface IProductService
    {
        bool SaveChanges();
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetAllProductsByGroupId(int id);
        Product GetProductByID(int id);
        void CreateProduct(Product model);
        void UpdateProduct(Product model);
        void DeleteProduct(Product model);
    }
}
