using Microsoft.EntityFrameworkCore;
using MVC___Session_1.Entities;
using System.Reflection;

namespace MVC___Session_1.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ;Database = GymManagementSystem ; Trusted_Connection = true; TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // fluent API
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DbSets

        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Membership> Memberships { get; set; }

        #endregion
    }
}
