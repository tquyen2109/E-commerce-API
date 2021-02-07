using ECommereceAPI.Messages.Request.Product;
using ECommereceAPI.Messages.Response.Product;

namespace ECommereceAPI.Services
{
    public interface ICatalogueService
    {
        FetchProductsResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}