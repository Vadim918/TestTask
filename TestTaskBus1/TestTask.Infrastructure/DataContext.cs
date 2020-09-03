using Microsoft.EntityFrameworkCore;
using TestTask.Core.Entities;

namespace TestTask.Infrastructure
{
    internal class DataContext : DbContext
    {
        private const string Connection = "server=localhost;database=mydemo;user=root;password=mypassword";

        public DbSet<Main> Main { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Connection);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////modelBuilder.ApplyConfiguration(new MainConfiguration());
        }
    }
}