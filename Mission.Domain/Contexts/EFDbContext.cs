using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Mission.Domain.Entities;

namespace Mission.Domain.Contexts
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
