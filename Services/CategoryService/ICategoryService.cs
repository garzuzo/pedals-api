using pedals_api.Models;

namespace pedals_api.Services.CategoryService;
public interface ICategoryService
{
    IEnumerable<Category> Get();
    Task Create(Category category);
}
