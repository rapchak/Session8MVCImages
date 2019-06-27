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
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime PostedOn { get; set; }
    }
}
