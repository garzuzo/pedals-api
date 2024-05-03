using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
public static class MediaTypeModelBuilder
{
    public static void Configure(this EntityTypeBuilder<MediaType> builder)
    {
        builder.ToTable("MediaType");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Type);
        var mediaTypes = new List<MediaType>();
        var videoMediaType = new MediaType()
        {
            Id = new Guid("baa94eb7-2328-4053-b5b8-8d2e9cce9edd"),
            Type = Models.Type.Video
        };
        mediaTypes.Add(videoMediaType);
        var imageMediaType = new MediaType()
        {
            Id = new Guid("77eee112-84e3-4f76-8be2-222875e7d207"),
            Type = Models.Type.Image
        };
        mediaTypes.Add(imageMediaType);
        builder.HasData(mediaTypes);
    }
}
