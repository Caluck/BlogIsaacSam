using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Data.ViewModelClasses
{
    public class PostAddVM
    {
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string Content { get; set; }

        public string CategoryLine { get; set; }
        public string TagLine { get; set; }

    }
}