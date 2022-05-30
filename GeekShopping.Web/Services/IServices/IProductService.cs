using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById(int id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task<bool> DeleteProductById(int id);
    }
}
