using BlogIsaacSam.DAL;
using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class PostRepositoryEF : IPostRepository
    {
        private BlogContext db = new BlogContext();

        public PostRepositoryEF()
        {
        }

        public void Add(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public Post Get(int postId)
        {
            return db.Posts.FirstOrDefault(i => i.PostId == postId);
        }

        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public List<Post> GetByCategory(int categoryId)
        {
            return db.Posts.Where(i => i.CategoryId == categoryId).ToList();
        }

        public void Remove(int postId)
        {
            Post post = new Post() { PostId = postId };
            db.Posts.Attach(post);
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}