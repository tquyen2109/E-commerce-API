using System.Collections.Generic;
using ECommereceAPI.Messages.DTOs.Product;

namespace ECommereceAPI.Messages.Response.Category
{
    public class FetchCategoriesResponse : ResponseBase
    {
        public int CategoriesPerPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPages { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<BrandDto> Categories { get; set; }
    }
}