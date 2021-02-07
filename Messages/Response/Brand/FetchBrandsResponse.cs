using System.Collections.Generic;
using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Brand
{
    public class FetchBrandsResponse : ResponseBase
    {
        public int BrandsPerPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPages { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<BrandDto> Brands { get; set; }
    }
}