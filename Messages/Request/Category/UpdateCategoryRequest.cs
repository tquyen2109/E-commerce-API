using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Request.Category
{
    public class UpdateCategoryRequest
    {
        public long Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}