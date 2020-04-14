using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class PostRepositoryMock : IPostRepository
    {
        private static List<Post> repository;

        public PostRepositoryMock()
        {
            repository = new List<Post>()
            {
                new Post() { PostId=0, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Mock Title", Content="Using Mock DB."},
                new Post() { PostId=1, Author="Isaac", DateCreated=DateTime.Now, DateEditted=DateTime.Now,
                             Title="Title 2: Electric Boogaloo", Content="Sample content."},
            };
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
            return repository;
        }

        public List<Post> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
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