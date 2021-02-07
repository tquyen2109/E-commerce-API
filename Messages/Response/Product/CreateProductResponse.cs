using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Product
{
    public class CreateProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}