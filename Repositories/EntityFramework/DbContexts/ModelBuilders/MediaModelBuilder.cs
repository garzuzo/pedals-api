using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
public static class MediaModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Media> builder)
    {
        builder.ToTable("Media");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Path);
        builder.HasOne(p => p.MediaType).WithOne().HasForeignKey<MediaType>(p => p.MediaId);
    }
}
