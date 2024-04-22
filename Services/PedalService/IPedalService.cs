namespace pedals_api.Services.PedalService;
using pedals_api.Models;
public interface IPedalService
{
    IEnumerable<Pedal> Get();
    Pedal? GetById(Guid id);
    Task Create(Pedal pedal);
    Task Update(Guid id, Pedal pedal);
    Task Delete(Guid id);

}
