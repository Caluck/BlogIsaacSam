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
        public BlogContext() : base("name=BlogDBConnectionString")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
    }
}