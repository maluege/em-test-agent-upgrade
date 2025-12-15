using Microsoft.EntityFrameworkCore;
using MySpendings.DataAccess.Data.Configurations;
using MySpendings.Models;

namespace MySpendings.DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public required DbSet<User> Users { get; set; }
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Outlay> Outlays { get; set; }
        public required DbSet<UserCategory> UserCategories { get; set; }
        public required DbSet<UserOutlay> UserOutlays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OutlayConfiguration());
            modelBuilder.ApplyConfiguration(new UserCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserOutlayConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
