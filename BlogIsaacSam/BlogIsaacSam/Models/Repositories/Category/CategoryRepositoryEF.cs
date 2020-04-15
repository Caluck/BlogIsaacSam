using BlogIsaacSam.DAL;
using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class CategoryRepositoryEF : ICategoryRepository
    {
        private BlogContext db = new BlogContext();

        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public Category Get(int categoryId)
        {
            return db.Categories.FirstOrDefault(i => i.CategoryId == categoryId);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Remove(int categoryId)
        {
            Category category = new Category() { CategoryId = categoryId };
            db.Categories.Attach(category);
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            Remove(category.CategoryId);
            Add(category);
        }
    }
}