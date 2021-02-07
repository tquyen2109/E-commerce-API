using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Product
{
    public class DeleteProductResponse : ResponseBase
    {
        public long Id { get; set; }
        public ProductDto Product { get; set; }
    }
}