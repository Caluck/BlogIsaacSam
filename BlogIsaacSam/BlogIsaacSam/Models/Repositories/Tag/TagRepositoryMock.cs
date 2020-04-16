using BlogIsaacSam.Models.Data;
using BlogIsaacSam.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class TagRepositoryMock : ITagRepository
    {
        private static List<Tag> list = new List<Tag>
        {
            new Tag { Name = "Fun", TagId = 0},
            new Tag { Name = "Cool", TagId = 1},
            new Tag { Name = "Hilarious", TagId = 2}
        };
        public void Add(Tag tag)
        {
            tag.TagId = list.Max(x => x.TagId) + 1;
            list.Add(tag);
        }

        public Tag Get(int tagId)
        {
            Tag tag = new Tag();
            foreach (var item in list)
            {
                if (item.TagId == tagId)
                {
                    tag = item;
                    break;
                }
            }
            return tag;
        }

        public List<Tag> GetAll()
        {
            return list;
        }

        public void Remove(int tagId)
        {
            Tag tag = Get(tagId);
            list.Remove(tag);
        }
    }
}