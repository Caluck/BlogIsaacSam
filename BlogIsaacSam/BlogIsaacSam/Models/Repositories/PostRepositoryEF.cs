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
            throw new NotImplementedException();
        }

        public Post Get(int postId)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public void Remove(int postId)
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}