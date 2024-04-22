using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;

public static class CategoryModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name);

        var categories = new List<Category>();
        var distortion = new Category()
        {
            Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
            Name = "Overdrive/Distortion"
        };
        categories.Add(distortion);
        var delay = new Category()
        {
            Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa5"),
            Name = "Delay/Reverb"
        };
        categories.Add(delay);
        var modulation = new Category()
        {
            Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa4"),
            Name = "Modulation"
        };
        categories.Add(modulation);
        builder.HasData(categories);
    }
}
