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

        public void Add(Data.Tag tag)
        {
            db.Tags.Add(tag);
            db.SaveChanges();
        }

        public Data.Tag Get(int tagId)
        {
            return db.Tags.FirstOrDefault(i => i.TagId == tagId);
        }

        public List<Data.Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public void Remove(int tagId)
        {
            Data.Tag tag = new Data.Tag() { TagId = tagId };
            db.Tags.Attach(tag);
            db.Tags.Remove(tag);
            db.SaveChanges();
        }
    }
}