using BlogIsaacSam.Models.Data;
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
            new Tag { Name = "Ironman", TagId = 0},
             new Tag { Name = "Ironman", TagId = 1}
        };

        public void Add(Tag tag)
        {
            tag.TagId = list.Max(x => x.TagId) + 1;
            list.Add(tag);
        }

        public Tag Get(int id)
        {
            Tag tag = new Tag();
            foreach (var item in list)
            {
                tag = item;
                break;
            }
            return tag;
        }
    }
}