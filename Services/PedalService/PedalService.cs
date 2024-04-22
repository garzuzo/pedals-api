using pedals_api.Models;
using pedals_api.Repositories.EntityFramework.DbContexts;

namespace pedals_api.Services.PedalService;

public class PedalService : IPedalService
{

    PedalsContext dbContext;
    private readonly ILogger<PedalService> _logger;
    public PedalService(PedalsContext dbContext, ILogger<PedalService> logger)
    {
        this.dbContext = dbContext;
        _logger = logger;
    }

    public IEnumerable<Pedal> Get()
    {
        return dbContext.Pedals;
    }
    public Pedal? GetById(Guid id)
    {
        return dbContext.Pedals.Find(id);
    }

    public async Task Update(Guid id, Pedal pedal)
    {
        var currentPedal = dbContext.Pedals.Find(id);
        if (currentPedal != null)
        {
            currentPedal.Name = pedal.Name;
            currentPedal.Description = pedal.Description;
            currentPedal.Price = pedal.Price;
            await dbContext.SaveChangesAsync();
        }
    }

    public async Task Create(Pedal pedal)
    {
        var currentPedal = dbContext.Pedals.Find(pedal.Id);

        if (currentPedal == null)
        {
            dbContext.Pedals.Add(pedal);
            await dbContext.SaveChangesAsync();
        }

    }

    public async Task Delete(Guid id)
    {
        try
        {
            var currentPedal = dbContext.Pedals.Find(id);
            if (currentPedal != null)
            {
                dbContext.Remove(currentPedal);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }
}
