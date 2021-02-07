using System.Collections.Generic;
using ECommereceAPI.Models.Product;

namespace ECommereceAPI.Repositories.Implementations
{
    public interface ICategoryRepository
    {
        Category FindCategoryById(long id);
        IEnumerable<Category> GetAllCategories();
        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}