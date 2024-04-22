using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
public static class ArtistModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Artist> builder)
    {
        builder.ToTable("Artist");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name);
        builder.Property(p => p.Description);
        builder.Property(p => p.Image);
    }
}