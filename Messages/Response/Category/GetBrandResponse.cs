using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Category
{
    public class GetCategoryResponse : ResponseBase
    {
        public CategoryDto Brand { get; set; }
    }
}