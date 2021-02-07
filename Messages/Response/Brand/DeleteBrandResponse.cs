using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Brand
{
    public class DeleteBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}