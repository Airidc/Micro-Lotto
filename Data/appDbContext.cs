using micro_lotto.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace micro_lotto.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bet> Bet { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Draw> Draw { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.HasKey(i => i.Id);
                u.Property(i => i.Id).ValueGeneratedOnAdd();
                u.HasData(
                    new User
                    {
                        Id = 1,
                        Balance = 9001,
                        Username = "Test User"
                    }); ;
            });
            modelBuilder.Entity<Bet>().Property(f => f.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Draw>().Property(f => f.Id).ValueGeneratedOnAdd();
        }
    }
}
