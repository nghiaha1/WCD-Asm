using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext() : base()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Class> _classes { get; set; }
    public DbSet<Course> _courses { get; set; }
    public DbSet<Student> _students { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Class>().ToTable("Classes");
        modelBuilder.Entity<Course>().ToTable("Courses");
        modelBuilder.Entity<Student>().ToTable("Students");
    }
}