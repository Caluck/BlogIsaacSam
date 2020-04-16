using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }

        [MaxLength(40000)]
        public string Content { get; set; }

        [MaxLength(64)]
        public string Author { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateEditted { get; set; }
        public int CategoryId { get; set; }
    }
}