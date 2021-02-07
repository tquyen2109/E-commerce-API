using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Product
{
    public class DeleteProductResponse : ResponseBase
    {
        public ProductDto Brand { get; set; }
    }
}