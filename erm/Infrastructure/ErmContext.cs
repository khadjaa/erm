using Erm.Models;
using Erm.Models;
using Microsoft.EntityFrameworkCore;

namespace Erm.Infrastructure
{
    public class ErmDbContext : DbContext
    {
        public ErmDbContext(DbContextOptions options) : base(options)
        {
            // this.Database.EnsureCreated();
        }

        public DbSet<Risk> Risk { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<MyTask> MyTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            var risk = new Risk();
            risk.Name = "firstRiskInContext";
            risk.Description = "descriptionInContext";
            risk.Impact = 1;
            risk.Probability = 2;

            modelBuilder.Entity<Risk>(entity => { entity.HasKey(p => p.Id); });

            modelBuilder.Entity<Risk>().HasData(
                risk,
                new Risk
                {
                    Name = "First Risk", Description = "Description of first risk", Probability = 2, Impact = 3
                },
                new Risk
                {
                    Name = "Second Risk", Description = "Description of second risk", Probability = 1, Impact = 2
                }
            );
            
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.HasIndex(p => p.Username).IsUnique();
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(p => p.FirstName).IsRequired().HasMaxLength(20).HasDefaultValue("first");

                entity.HasData(new Worker()
                {
                    FirstName = "first",
                    LastName = "last",
                    Role = "admin",
                    Username = "maga",
                    Password = "123",
                    RefreshToken = "refresh_token_value",
                    Responsibility = "some_responsibility"
                });

                entity.HasData(new Worker()
                {
                    FirstName = "second",
                    LastName = "last1",
                    Role = "editor",
                    Username = "baha",
                    Password = "222",
                    RefreshToken = "refresh_token_value1",
                    Responsibility = "some_responsibility1"
                });
            });

            modelBuilder.Entity<MyTask>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(20).HasDefaultValue("first");

                entity.HasData(new MyTask()
                {
                    Name = "first task",
                    StartDate = new DateTime(2012, 12, 12),
                    EndDate = new DateTime(2015, 12, 15),
                    AssignedTo = "John Doe"
                });
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}