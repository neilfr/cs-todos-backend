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
        var builder = WebApplication.CreateBuilder();
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        }
    }
    public DbSet<MyTask> MyTasks { get; set; }
    public DbSet<Stage> Stages { get; set; }
}
