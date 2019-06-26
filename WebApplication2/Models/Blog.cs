using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public int WordCount {
            get {
                // return some number of words based on text
                int words = Text.Split(' ').Count();
                return words;
            }
        }
        public string Text { get; set; }
        public DateTime PostedOn { get; set; }
    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
    }
}
