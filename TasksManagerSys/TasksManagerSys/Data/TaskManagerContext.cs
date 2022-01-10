using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TasksManagerSys.Data
{
    public class TaskManagerContext:IdentityDbContext<AppUser>
    {
        public DbSet<Project> project { get; set; }
        public DbSet<Task> task { get; set; }
        public DbSet<AppUser> appUser { get; set; }

        IConfiguration configuration;

        public TaskManagerContext(IConfiguration _configuration) 
        { 
            configuration = _configuration; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(configuration.GetConnectionString("TaskMngConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
