using System.Collections.Generic;
using ECommereceAPI.Database;
using ECommereceAPI.Models.Product;

namespace ECommereceAPI.Repositories
{
    public interface IProductRepository
    {
        Product FindProductById(long id);
        IEnumerable<Product> GetAllProducts();
        void SaveProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}