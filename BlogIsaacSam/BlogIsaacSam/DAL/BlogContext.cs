using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}