using System.Collections;
using pedals_api.Models;
using pedals_api.Repositories.EntityFramework.DbContexts;

namespace pedals_api.Services.CategoryService;
public class CategoryService : ICategoryService
{
    private PedalsContext dbContext;
    public CategoryService(PedalsContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IEnumerable<Category> Get()
    {
        return dbContext.Categories;
    }
    public async Task Create(Category category)
    {
        var currentCategory = dbContext.Categories.Find(category.Id);
        if (currentCategory == null)
        {
            dbContext.Categories.Add(category);
            await dbContext.SaveChangesAsync();
        }
    }

}
