using System;
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

            modelBuilder.Entity<Main>().HasData(new Main
                {
                    Id = new Guid("716C2E99-6F6C-4472-81A5-43C56E11637C"),
                    LongUrl = "https://www.instagram.com/zab.91/",
                    EditableUrl = "https://bit.ly/3b2lFle",
                    Date = DateTime.Today.Date
                },
                new Main
                {
                    Id = new Guid("BFCBBEC9-0023-4A6F-B466-A099F11F3B09"),
                    LongUrl = "https://github.com/Vadim918",
                    EditableUrl = "https://cutt.ly/dfzomFL",
                    Date = DateTime.Today
                },
                new Main
                {
                    Id = new Guid("F7E42B20-9F4F-44FF-A7E3-C65C4772B308"),
                    LongUrl = "https://metanit.com/sharp/aspnet5/1.1.php",
                    EditableUrl = "https://cutt.ly/7fzoZjB",
                    Date = DateTime.Today
                }
            );
        }
    }
}