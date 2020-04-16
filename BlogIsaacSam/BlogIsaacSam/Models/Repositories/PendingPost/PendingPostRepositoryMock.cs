using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class PendingPostRepositoryMock : IPendingPostRepository
    {
        private static List<Post> list = new List<Post>();
        public void Create(Post post)
        {
            post.PostId = list.Max(x => x.PostId) + 1;
            list.Add(post);
        }

        public void Delete(int id)
        {
            list.Remove(Get(id));
        }

        public Post Get(int id)
        {
            Post post = new Post();
            foreach (var item in list)
            {
                if (item.PostId == id)
                {
                    post = item;
                }
            }
            return post;
        }

        public List<Post> GetAll()
        {
            return list;
        }
    }
}