using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIsaacSam.Models.Repositories
{
    public interface IPendingPostRepository
    {
        List<Post> GetAll();
        Post Get(int id);
        void Create(Post post);
        void Delete(int id);
    }
}
