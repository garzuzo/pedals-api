namespace pedals_api.Models;

public class MediaType
{
    public Guid Id { get; set; }
    public Type Type { get; set; }
}
public enum Type
{
    Image, Video
}
