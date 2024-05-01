
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;
namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
public static class PedalModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Pedal> builder)
    {
        builder.ToTable("Pedal");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name);
        builder.Property(p => p.Description);
        builder.Property(p => p.Price);
        builder.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        builder.HasMany(p => p.Products).WithOne().HasForeignKey(p => p.PedalId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        builder.HasMany(p => p.Moments).WithOne().HasForeignKey(p => p.PedalId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        builder.HasMany(p => p.Medias).WithOne().HasForeignKey(p => p.PedalId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
    }
}
