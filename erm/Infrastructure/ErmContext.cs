using Erm.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Erm.Infrastructure
{
    public class ErmDbContext : DbContext
    {
        public ErmDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Risk> Risk { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<MyTask> MyTasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Issue> Issues { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}