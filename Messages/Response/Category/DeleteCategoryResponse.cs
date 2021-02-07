using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Category
{
    public class DeleteCategoryResponse : ResponseBase
    {
        public CategoryDto Brand { get; set; }
    }
}