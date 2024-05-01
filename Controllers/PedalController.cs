namespace pedals_api.Controllers;
using Microsoft.AspNetCore.Mvc;
using pedals_api.Models;
using pedals_api.Services.PedalService;

[ApiController]
[Route("api/[controller]")]
public class PedalController : ControllerBase
{

    private readonly ILogger<PedalController> logger;
    private IPedalService pedalService;
    public PedalController(ILogger<PedalController> logger, IPedalService pedalService)
    {
        this.logger = logger;
        this.pedalService = pedalService;
    }
    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok(pedalService.Get());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(pedalService.GetById(id));
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Pedal pedal)
    {
        await pedalService.Create(pedal);
        return Ok();
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Pedal pedal)
    {
        await pedalService.Update(id, pedal);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await pedalService.Delete(id);
        return Ok();
    }
}
