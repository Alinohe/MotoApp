
namespace MotoApp.Data;
using Microsoft.EntityFrameworkCore;
using MotoApp.Data.Entities;


public class MotoAppDbContext : DbContext
{
    public MotoAppDbContext(DbContextOptions<MotoAppDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }


}

