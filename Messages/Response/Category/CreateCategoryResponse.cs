using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Category
{
    public class CreateCategoryResponse : ResponseBase
    {
        public long Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}