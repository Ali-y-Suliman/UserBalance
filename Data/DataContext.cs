using Microsoft.EntityFrameworkCore;
using UserBalanceAPI.Models;

namespace UserBalanceAPI.Data
{
    public class UserBalanceContext : DbContext
    {
        public UserBalanceContext(DbContextOptions<UserBalanceContext> options) : base(options)
        {
        }

        public DbSet<UserBalance> UserBalances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Users
            modelBuilder.Entity<UserBalance>().HasData(
                new UserBalance { Id = 1, Email = "user1@example.com", Balance = 5000m },
                new UserBalance { Id = 2, Email = "user2@example.com", Balance = 1000m },
                new UserBalance { Id = 3, Email = "user3@example.com", Balance = 2000m },
                new UserBalance { Id = 4, Email = "user4@example.com", Balance = 1500m }
            );

            modelBuilder.Entity<UserBalance>()
            .Property(t => t.Balance)
            .HasPrecision(6, 2);
        }
    }
}
