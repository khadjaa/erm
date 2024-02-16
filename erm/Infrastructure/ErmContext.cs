using erm.Models;
using Microsoft.EntityFrameworkCore;

public class ErmDbContext : DbContext
{
    public ErmDbContext(DbContextOptions options) : base(options)
    {}

    // Добавьте DbSet для ваших сущностей здесь
    public DbSet<Risk> Risks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<BaseEntity>();

        var risk = new Risk();
        risk.Name = "firstRiskInContext";
        risk.Description = "descriptionInContext";
        risk.Impact = Impact.High;
        risk.Probability = Probability.Low;
        
        modelBuilder.Entity<Risk>(entity =>
        {
            entity.HasKey(p => p.Id);
        });
        
        // Если у вас есть данные, которые вы хотите добавить при инициализации базы данных,
        // используйте метод HasData:

        modelBuilder.Entity<Risk>().HasData(
            new Risk { Name = "First Risk", Description = "Description of first risk", Probability = Probability.High, Impact = Impact.High },
            new Risk { Name = "Second Risk", Description = "Description of second risk", Probability = Probability.Medium, Impact = Impact.Medium }
        );

        base.OnModelCreating(modelBuilder);
    }
}