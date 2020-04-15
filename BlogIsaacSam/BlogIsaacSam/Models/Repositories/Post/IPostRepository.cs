using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIsaacSam.Models.Repositories
{
    public interface IPostRepository
    {
        void Add(Post post);
        Post Get(int postId);
        List<Post> GetAll();
        void Remove(int postId);
        void Update(Post post);
    }
}