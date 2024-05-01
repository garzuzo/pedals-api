using pedals_api.Models;
using pedals_api.Repositories.EntityFramework.DbContexts;

namespace pedals_api.Services.ProductService;

public class ProductService : IProductService
{
    private readonly PedalsContext dbContext;
    public ProductService(PedalsContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task Create(Product product)
    {
        var currentProduct = dbContext.Products.Find(product);
        if (currentProduct == null)
        {
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();
        }
    }
}
