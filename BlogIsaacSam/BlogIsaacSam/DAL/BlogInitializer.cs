using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.DAL
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var posts = new List<Post>()
            {
                new Post() { PostId=0, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title", Content="Sample content."},
                new Post() { PostId=1, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title 2: Electric Boogaloo", Content="Sample content."},
            };

            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}