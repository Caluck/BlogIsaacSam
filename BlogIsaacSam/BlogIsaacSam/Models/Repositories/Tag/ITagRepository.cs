﻿using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIsaacSam.Models.Repositories
{
    public interface ITagRepository
    {
        void Add(Tag tag);
        Tag Get(int id);
    }
}
