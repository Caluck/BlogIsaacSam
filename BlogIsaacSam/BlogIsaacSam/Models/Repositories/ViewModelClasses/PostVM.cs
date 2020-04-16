using BlogIsaacSam.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories.ViewModelClasses
{
    public class PostVM
    {
        public Post Post { get; set; }
        public List<Tag> Tags { get; set; }
        public Category PostCategory { get; set; }
        public ApplicationUser User { get; set; }

        public string TagString { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}