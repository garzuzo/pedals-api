using Microsoft.EntityFrameworkCore;
using pedals_api.Models;
using pedals_api.Repositories.EntityFramework.DbContexts.ModelBuilders;
namespace pedals_api.Repositories.EntityFramework.DbContexts;

public class PedalsContext : DbContext
{
    public DbSet<Pedal> Pedals { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Moment> Moments { get; set; }


    public PedalsContext(DbContextOptions<PedalsContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pedal>().Configure();
        modelBuilder.Entity<Artist>().Configure();
        modelBuilder.Entity<Category>().Configure();
        modelBuilder.Entity<Media>().Configure();
        modelBuilder.Entity<Moment>().Configure();
        modelBuilder.Entity<Product>().Configure();
    }
}
