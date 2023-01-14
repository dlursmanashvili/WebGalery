using Microsoft.EntityFrameworkCore;
using WebGallery.DTO;

namespace WebGallery.Repositories;

public class MyDbContext : DbContext
{
    private const string ConnectionString = @"server=.; database=myDB; integrated security=true;TrustServerCertificate=True;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<PhotoItem>? PhotoItems { get; set; }
    public DbSet<Comment>? Comments { get; set; }
}
