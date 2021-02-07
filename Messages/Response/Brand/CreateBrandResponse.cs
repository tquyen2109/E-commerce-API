using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Brand
{
    public class CreateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}