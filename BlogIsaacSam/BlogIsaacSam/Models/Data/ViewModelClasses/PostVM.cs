using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Data.ViewModelClasses
{
    public class PostVM
    {
        public Post Post { get; set; }
        public List<Tag> Tags { get; set; }
        public Category Category { get; set; }
    }
}