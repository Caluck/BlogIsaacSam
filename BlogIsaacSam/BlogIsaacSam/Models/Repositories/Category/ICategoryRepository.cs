using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIsaacSam.Models.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category Get(int categoryId);
        List<Category> GetAll();
        void Remove(int categoryId);
        void Update(Category category);
    }
}
