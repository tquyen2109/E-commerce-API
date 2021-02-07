using System.Collections.Generic;
using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Product
{
    public class FetchProductsResponse : ResponseBase
    {
        public int ProductsPerPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPages { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<ProductDto> Brands { get; set; }
    }
}