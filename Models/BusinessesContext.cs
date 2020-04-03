using Microsoft.EntityFrameworkCore;

namespace Businesses.Models
{
  public class BusinessesContext : DbContext
  {
    public BusinessesContext(DbContextOptions<BusinessesContext>options)
      :base(options)
    {

    }
    public DbSet<Businesses> Businesses { get; set; }
  }
}