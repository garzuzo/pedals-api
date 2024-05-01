using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pedals_api.Models;

namespace pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
public static class ProductModelBuilder
{
    public static void Configure(this EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");
        builder.HasKey(p=>p.Id);
        builder.Property(p=>p.Link);
        
    }
}
