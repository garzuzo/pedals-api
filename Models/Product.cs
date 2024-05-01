namespace pedals_api.Models;
public class Product
{
    public Guid Id { get; set; }
    public string Link { get; set; }
    public Guid PedalId { get; set; }
}
