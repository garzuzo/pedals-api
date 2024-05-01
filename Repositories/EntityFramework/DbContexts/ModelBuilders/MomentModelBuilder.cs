using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;

public static class MomentModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Moment> builder)
    {
        builder.ToTable("Moment");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Title);
        builder.Property(p => p.Summary);
        //builder.HasOne(p => p.Artist).WithMany(p => p.Moments).HasForeignKey(p => p.ArtistId);
        //builder.HasOne(p => p.Reference).WithMany(p => p.Moments).HasForeignKey(p => p.PedalId);

        //builder.HasMany(p => p.Medias).WithOne().HasForeignKey(p => p.MomentId);
    }
}
