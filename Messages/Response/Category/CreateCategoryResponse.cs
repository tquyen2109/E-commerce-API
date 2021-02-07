using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Category
{
    public class CreateCategoryResponse : ResponseBase
    {
        public CategoryDto Brand { get; set; }
    }
}