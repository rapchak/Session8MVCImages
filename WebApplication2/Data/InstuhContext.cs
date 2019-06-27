using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Data
{
    public class InstuhDbContext : DbContext
    {
        public InstuhDbContext(DbContextOptions<InstuhDbContext> options) : base(options)   
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}
