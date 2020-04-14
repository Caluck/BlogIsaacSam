using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Creator { get; set; }

        public DateTime DateCreated { get; set; }
    }
}