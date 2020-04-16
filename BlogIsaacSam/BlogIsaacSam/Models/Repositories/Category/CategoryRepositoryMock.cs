using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class CategoryRepositoryMock : ICategoryRepository
    {
        private static List<Category> list = new List<Category>
        {
            new Category { CategoryId = 0, Creator = "Sam", DateCreated = new DateTime(1/2/02), Name = "Awesome"},
            new Category { CategoryId = 0, Creator = "Sam", DateCreated = new DateTime(1/2/02), Name = "Interesting"}
        };

        public void Add(Category category)
        {
            category.CategoryId = list.Max(x => x.CategoryId) + 1;
        }

        public Category Get(int categoryId)
        {
            Category category = new Category();
            foreach (var item in list)
            {
                if (item.CategoryId == categoryId)
                {
                    category = item;
                }
            }
            return category;
        }

        public List<Category> GetAll()
        {
            return list;
        }

        public void Remove(int categoryId)
        {
            list.Remove(Get(categoryId));
        }

        public void Update(Category category)
        {
            list.Remove(Get(category.CategoryId));
            list.Add(category);
        }
    }
}