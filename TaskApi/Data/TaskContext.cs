using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaskApi.Entities;

namespace TaskApi
{
    public class TaskContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=taskapi;Username=postgres;Password=password")
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Name},LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }
    
}