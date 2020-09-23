using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListWebApplication.Models.Entity;

namespace TodoListWebApplication.Models.DataContext
{
    public class TodoTaskDataContext:DbContext
    {
        public TodoTaskDataContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Task");
            builder.Entity<Todo>().Property(e => e.CreatedDate).HasDefaultValueSql("DATEADD(HOUR,4,getutcdate())");
        }
        public  DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
