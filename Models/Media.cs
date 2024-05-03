namespace pedals_api.Models;
public class Media
{
    public Guid Id { get; set; }
    public string Path { get; set; }
    public MediaType? MediaType { get; set; }
    public Guid MediaTypeId { get; set; }
    public Guid MomentId { get; set; }
    public Guid PedalId { get; set; }
}
