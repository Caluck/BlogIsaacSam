using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.DAL
{
    // Switch to DropCreateDatabaseIfModelChanges at some point.
    public class BlogInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var posts = new List<Post>()
            {
                new Post() { PostId=0, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title", Content="Sample content." },
                new Post() { PostId=1, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title 2: Electric Boogaloo", Content="Sample content." },
                new Post() { PostId=2, Author="Author", DateCreated=DateTime.Parse("1-1-2011"), DateEditted=DateTime.Parse("1-1-2011"),
                             Title="Title", Content="This is the content of the post. This incredibly large box should represent the post making it to the page." },
                new Post() { PostId=3, Author="Author", DateCreated=DateTime.Parse("1-1-2011"), DateEditted=DateTime.Parse("1-1-2011"),
                             Title="Title", Content="This is the content of the post. This incredibly large box should represent the post making it to the page.\nStrangely enough, this appears to be a second post. How odd. I wonder how math works. Do you? I don't know.\nThis text is placed into here as merely a test, why are you reading it so much?" },
            };

            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();
        }
    }
}