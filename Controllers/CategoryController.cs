using Microsoft.AspNetCore.Mvc;
using pedals_api.Models;
using pedals_api.Services.CategoryService;

namespace pedals_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private ILogger<CategoryController> _logger;
    private ICategoryService _categoryService;
    public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
    {
        _logger = logger;
        _categoryService = categoryService;
    }
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_categoryService.Get());
    }
    [HttpPost]
    public async Task<IActionResult> Create(Category category)
    {
        _logger.LogInformation("Creating a category");
        await _categoryService.Create(category);
        return Ok();
    }
}
