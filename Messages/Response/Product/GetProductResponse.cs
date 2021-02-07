using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Product
{
    public class GetProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}