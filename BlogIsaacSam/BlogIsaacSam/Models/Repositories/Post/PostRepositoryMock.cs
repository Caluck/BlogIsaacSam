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
            post.PostId = repository.Max(x => x.PostId) + 1;
            repository.Add(post);
        }

        public Post Get(int postId)
        {
            Post post = new Post();
            foreach (var item in repository)
            {
                if (item.PostId == postId)
                {
                    post = item;
                    break;
                }
            }
            return post;
        }

        public List<Post> GetAll()
        {
            return repository;
        }

        public List<Post> GetByCategory(int categoryId)
        {
            List<Post> list = new List<Post>();
            foreach (var item in repository)
            {
                if (item.CategoryId == categoryId)
                {
                    list.Add(item);
                    break;
                }
            }
            return list;
        }

        public void Remove(int postId)
        {
            Post post = Get(postId);
            repository.Remove(post);
        }

        public void Update(Post post)
        {
            repository.Remove(Get(post.PostId));
            repository.Add(post);
        }
    }
}