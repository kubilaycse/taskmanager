using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskmanager.Models
{
    public class taskDBContext:DbContext
    {
        public taskDBContext(DbContextOptions<taskDBContext> dbContextOptions): base(dbContextOptions) { }
        public DbSet<Task> Tasks { get; set; }
    }
}
