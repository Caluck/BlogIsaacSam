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

            var categories = new List<Category>()
            {
                new Category() { Name="General",
                                 Creator="Isaac", DateCreated=DateTime.Now },
                new Category() { Name="Programming",
                                 Creator="Isaac", DateCreated=DateTime.Now },
            };
            categories.ForEach(i => context.Categories.Add(i));
            context.SaveChanges();

            var posts = new List<Post>()
            {
                new Post() { Author="Isaac", CategoryId=1,
                             DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title", Content="Sample content." },
                new Post() { Author="Isaac", CategoryId=2,
                             DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title 2: Electric Boogaloo", Content="Sample content." },
                new Post() { Author="Author", CategoryId=1,
                             DateCreated=DateTime.Parse("1-1-2011"), DateEditted=DateTime.Parse("1-1-2011"),
                             Title="Title", Content="This is the content of the post. This incredibly large box should represent the post making it to the page." },
                new Post() { Author="Author", CategoryId=2,
                             DateCreated=DateTime.Parse("1-1-2011"), DateEditted=DateTime.Parse("1-1-2011"),
                             Title="Title", Content="This is the content of the post. This incredibly large box should represent the post making it to the page.\nStrangely enough, this appears to be a second post. How odd. I wonder how math works. Do you? I don't know.\nThis text is placed into here as merely a test, why are you reading it so much?" },
            };
            posts.ForEach(i => context.Posts.Add(i));
            context.SaveChanges();

            var tags = new List<Tag>()
            {
                new Tag() { TagId=0, Name="hello" },
                new Tag() { TagId=1, Name="world" },
            };
            tags.ForEach(i => context.Tags.Add(i));
            context.SaveChanges();

        }
    }
}