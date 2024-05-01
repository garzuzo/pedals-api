namespace pedals_api.Models;

public class Artist
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Moment> Moments { get; set; }
}