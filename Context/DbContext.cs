using IndoorPlantsC_.Models;
using Microsoft.EntityFrameworkCore;

namespace IndoorPlantsC_.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Plant>? Plants { get; set; }
    public DbSet<User>? Users { get; set; }

}
