using pedals_api.Models;

namespace pedals_api.Services.ProductService;

public interface IProductService
{
    Task Create(Product product);
}
