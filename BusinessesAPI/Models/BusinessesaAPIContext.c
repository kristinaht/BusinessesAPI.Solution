using Microsoft.EntityFrameworkCore;

namespace BusinessesApi.Models
{
  public class BusinessesApiContext : DbContext
  {
    public BusinessesApiContext(DbContextOptions<BusinessesApiContext>options)
      :base(options)
    {

    }
    public DbSet<BusinessesApi> BusinessesApi { get; set; }
  }
}