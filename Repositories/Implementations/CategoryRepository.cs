using System.Collections.Generic;
using ECommereceAPI.Database;
using ECommereceAPI.Models.Product;

namespace ECommereceAPI.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public Category FindCategoryById(long id)
        {
            var category = _context.Categories.Find(id);
            return category;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var notes = _context.Categories;
            return notes;
        }

        public void SaveCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}