using InternetVeikals.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetVeikals.Data.CartService
{
    public interface ICartService
    {
        bool SaveChanges();
        //IEnumerable<CartReadDTO> GetAllCategories();
        CartReadDTO GetCartByID(int id);
        CartReadDTO UpdateCart(int id, string action, int productId);

        //void CreateCategory(Category model);
        //void UpdateCategory(Category model);
        //void DeleteCategory(Category model);
    }
}
