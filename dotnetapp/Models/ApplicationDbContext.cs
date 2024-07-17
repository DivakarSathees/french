using Microsoft.EntityFrameworkCore;


namespace dotnetapp.Models
{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Batch> Batches { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // Configure the relationships between entities
        // modelBuilder.Entity<Student>()
        //     .HasOne(s => s.Batch)
        //     .WithMany(b => b.Students)
        //     .HasForeignKey(s => s.BatchID);

        modelBuilder.Entity<Batch>().HasData(
                new Batch { BatchID = 1, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), Capacity = 30 },
                new Batch { BatchID = 2, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1), Capacity = 25 },
                new Batch { BatchID = 3, StartTime = DateTime.Now.AddDays(2), EndTime = DateTime.Now.AddDays(2).AddHours(1), Capacity = 20 },
                new Batch { BatchID = 4, StartTime = DateTime.Now.AddDays(3), EndTime = DateTime.Now.AddDays(3).AddHours(1), Capacity = 15 },
                new Batch { BatchID = 5, StartTime = DateTime.Now.AddDays(4), EndTime = DateTime.Now.AddDays(4).AddHours(1), Capacity = 10 }
            );

        base.OnModelCreating(modelBuilder);
    }
}
}
