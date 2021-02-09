using System.Collections.Generic;
using ECommereceAPI.Messages.Request.Product;
using ECommereceAPI.Messages.Response.Product;
using ECommereceAPI.Models.Product;

namespace ECommereceAPI.Services
{
    public interface IProductService
    {
        CreateProductResponse SaveProduct(CreateProductRequest createProductRequest);
        UpdateProductResponse EditProduct(UpdateProductRequest updateProductRequest);
        GetProductResponse GetProduct(GetProductRequest getProductRequest);
        FetchProductsResponse GetProducts(FetchProductsRequest fetchProductsRequest);
        DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest);
    }
}