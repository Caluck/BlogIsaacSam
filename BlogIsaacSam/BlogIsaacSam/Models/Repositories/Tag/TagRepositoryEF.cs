using BlogIsaacSam.DAL;
using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class TagRepositoryEF : ITagRepository
    {
        private BlogContext db = new BlogContext();
        
        public void Add(Tag tag)
        {
            var item = db.Tags;
            tag.TagId = item.Max(x => x.TagId) + 1;
            item.Add(tag);
        }

        public Tag Get(int id)
        {
            Tag tag = new Tag();
            foreach (var item in db.Tags)
            {
                if (item.TagId == id)
                {
                    tag = item;
                    break;
                }
            }
            return tag;
        }
    }
}