

namespace pedals_api.Models;
public class Pedal
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Media>? Medias { get; set; }
    public Double Price { get; set; }
    //public virtual Pedal Pedal { get; set; }
    public ICollection<Moment>? Moments { get; set; }
    public ICollection<Product>? Products { get; set; }
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
}
