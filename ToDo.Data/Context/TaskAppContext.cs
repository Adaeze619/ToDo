using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Context
{
    public class TaskAppContext : DbContext
    {
        public TaskAppContext(DbContextOptions<TaskAppContext> options) : base(options)
        {
                
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
