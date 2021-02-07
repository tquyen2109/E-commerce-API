using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Brand
{
    public class GetBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}