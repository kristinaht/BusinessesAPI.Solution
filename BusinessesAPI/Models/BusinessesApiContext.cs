using Microsoft.EntityFrameworkCore;

namespace BusinessesApi.Models
{
  public class BusinessesApiContext : DbContext
  {
    public BusinessesApiContext(DbContextOptions<BusinessesApiContext> options)
      : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId=1, Name="Piazza Italia", Description="Italian Restaurant"},
          new Business { BusinessId=2, Name="Nordstrom", Description="Department store"},
          new Business { BusinessId=3, Name="New Seasons", Description="Grocery store"},
          new Business { BusinessId=4, Name="Umbria", Description="Caffee"}
        );
    }
  }
}