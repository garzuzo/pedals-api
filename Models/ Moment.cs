namespace pedals_api.Models;
public class Moment
{
    public Guid Id { get; set; }
    public Guid ArtistId { get; set; }
    public Guid PedalId { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public ICollection<Media> Medias { get; set; }
    //public Artist Artist { get; set; }
    //public Reference Reference { get; set; }
}
