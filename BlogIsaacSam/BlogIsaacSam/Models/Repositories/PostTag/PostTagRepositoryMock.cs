using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class PostTagRepositoryMock : IPostTagRepository
    {
        private static List<PostTag> list = new List<PostTag>
        {
            new PostTag { PostId = 0, PostTagId = 0, TagId = 0},
            new PostTag { PostTagId = 1, TagId = 1, PostId = 1}
        };

        public void Create(PostTag postTag)
        {
            postTag.PostTagId = list.Max(x => x.PostTagId) + 1;
        }

        public List<PostTag> GetAll()
        {
            return list;
        }

        public List<PostTag> GetAllByPost(int id)
        {
            List<PostTag> newList = new List<PostTag>();
            foreach (var item in list)
            {
                if (item.PostId == id)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}