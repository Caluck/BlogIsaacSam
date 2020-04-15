using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIsaacSam.Models.Repositories.Tag
{
    public interface ITagRepository
    {
        void Add(Data.Tag tag);
        Data.Tag Get(int tagId);
        List<Data.Tag> GetAll();
        void Remove(int tagId);
    }
}
