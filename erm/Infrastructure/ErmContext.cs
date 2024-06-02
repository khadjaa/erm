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
        //public DbSet<Person> Persons { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<MyTask> MyTasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Issue> Issues { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*            modelBuilder.Entity<MyTask>(entity =>
                        {
                            //entity.HasKey(p => p.Id);


                        });*/


            /*   modelBuilder.Ignore<BaseEntity>();

               var risk = new Risk();
               risk.Name = "firstRiskInContext";
               risk.Description = "descriptionInContext";
               risk.Impact = 1;
               risk.Probability = 2;
   */
            modelBuilder.Entity<Risk>(entity => { entity.HasKey(p => p.Id); });

            /* modelBuilder.Entity<Risk>().HasData(
                 risk,
                 new Risk
                 {
                     Name = "First Risk",
                     Description = "Description of first risk",
                     Probability = 2,
                     Impact = 3
                 },
                 new Risk
                 {
                     Name = "Second Risk",
                     Description = "Description of second risk",
                     Probability = 1,
                     Impact = 2
                 }
             );*/

            //modelBuilder.Entity<Person>(entity =>
            //{
            //    entity.HasKey(p => p.Id);
            //    entity.HasIndex(p => p.Username).IsUnique();
            //});

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(p => p.Id);
                ///entity.Property(p => p.FirstName).IsRequired().HasMaxLength(20).HasDefaultValue("first");

                /*   entity.HasData(new Worker()
                   {
                       FirstName = "first",
                       LastName = "last",
                       Role = "admin",
                       Username = "maga",
                       Password = "123",
                       RefreshToken = "refresh_token_value",
                       Responsibility = "some_responsibility"
                   });*/
                /*
                                entity.HasData(new Worker()
                                {
                                    FirstName = "second",
                                    LastName = "last1",
                                    Role = "editor",
                                    Username = "baha",
                                    Password = "222",
                                    RefreshToken = "refresh_token_value1",
                                    Responsibility = "some_responsibility1"
                                });*/
            });

            modelBuilder.Entity<MyTask>(entity =>
            {
                entity.HasKey(p => p.Id);
                //entity.Property(p => p.Name).IsRequired().HasMaxLength(20).HasDefaultValue("first");


                entity
                    .HasMany(w => w.Workers)
                    .WithOne(t => t.MyTasks)
                    .HasForeignKey(fk => fk.MyTaskId);
                /*entity.HasData(new MyTask()
                {
                    Name = "first task",
                    StartDate = new DateTime(2012, 12, 12),
                    EndDate = new DateTime(2015, 12, 15),
                    AssignedTo = "John Doe"
                });*/
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Projects");
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(20).HasDefaultValue("first");

                /*  entity.HasData(new Project()
                  {
                      Name = "first Project",
                      StartDate = new DateTime(2012, 12, 12),
                      EndDate = new DateTime(2016, 12, 15),
                      Sprints = "3",
                      Risks = "risks",
                      AssignedTo = "Scrum"
                  });*/
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(20).HasDefaultValue("first sprint");

                /*  entity.HasData(new Sprint()
                  {
                      Name = "first Sprint",
                      StartDate = new DateTime(2023, 12, 12),
                      EndDate = new DateTime(2024, 12, 15),
                      Tasks = "tasks for sprint"
                  });*/
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(20).HasDefaultValue("first Issue");

                /* entity.HasData(new Issue()
                 {
                     Name = "first Issue",
                     StartDate = new DateTime(2024, 01, 01),
                     EndDate = new DateTime(2024, 11, 15),
                     FindByWorker = "Find By Worker"
                 });*/
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}