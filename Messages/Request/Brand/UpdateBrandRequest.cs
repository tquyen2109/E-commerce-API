using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Request.Brand
{
    public class UpdateBrandRequest
    {
        public long Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}