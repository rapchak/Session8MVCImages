using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Post
    {
        public int Id { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime PostedOn { get; set; }
    }
=======
=======
>>>>>>> c282c1aa95df496dcf6fdb8d7a0d042d9ce3b04b
        public int UserID { get; set; }
        public string ImageURL { get; set; }
        public DateTime PostedOn { get; set; }
    }

//    public class PostDbContext : DbContext //old context from the exercise
//    {
//        public DbSet<Post> Posts { get; set; }

//        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
//        {

//        }
//    }
<<<<<<< HEAD
>>>>>>> 35a1a1ebf6ac294e98a94c7d6cbde44fced5089d
=======
>>>>>>> c282c1aa95df496dcf6fdb8d7a0d042d9ce3b04b
}
