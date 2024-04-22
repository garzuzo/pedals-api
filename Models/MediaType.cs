namespace pedals_api.Models;

public class MediaType
{
    public int Id { get; set; }
    public Type Type { get; set; }
    public Guid MediaId { get; set; }
}
public enum Type
{
    Image, Video
}