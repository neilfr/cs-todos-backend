using cs_todos_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace cs_todos_backend.Contexts;

public class MyDbContext : DbContext
{
 
    public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("server=localhost;port=1434;database=test_db;password=Super_Secret_Password_123");
        }
    }
    public DbSet<MyTask> MyTasks { get; set; }
    public DbSet<Stage> Stages { get; set; }
}
