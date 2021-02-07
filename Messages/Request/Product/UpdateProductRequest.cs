using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public long Id { get; set; }
        public ProductDto Product { get; set; }
    }
}