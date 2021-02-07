using System.Collections.Generic;
using ECommereceAPI.Database;
using ECommereceAPI.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace ECommereceAPI.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public Product FindProductById(long id)
        {
            var Product = _context.Products.Find(id);
            return Product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _context.Products
               .Include(p => p.Category)
               .Include(p => p.Brand);
            return products;
        }

        public void SaveProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}