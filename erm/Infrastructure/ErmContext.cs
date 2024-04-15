using erm.Models;
using Microsoft.EntityFrameworkCore;

public class ErmDbContext : DbContext
{
    public ErmDbContext(DbContextOptions options) : base(options)
    {
        // this.Database.EnsureCreated();
    }

    public DbSet<Risk> Risk { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<BaseEntity>();

        var risk = new Risk();
        risk.Name = "firstRiskInContext";
        risk.Description = "descriptionInContext";
        risk.Impact = 1;
        risk.Probability = 2;
        
        modelBuilder.Entity<Risk>(entity =>
        {
            entity.HasKey(p => p.Id);
        });
        
        // Если у вас есть данные, которые вы хотите добавить при инициализации базы данных,
        // используйте метод HasData:

        modelBuilder.Entity<Risk>().HasData(
            risk,
            new Risk { Name = "First Risk", Description = "Description of first risk", Probability = 2, Impact = 3 },
            new Risk { Name = "Second Risk", Description = "Description of second risk", Probability = 1, Impact = 2 }
        );

        base.OnModelCreating(modelBuilder);
    }
}