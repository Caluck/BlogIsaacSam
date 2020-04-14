﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Data
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
    }
}