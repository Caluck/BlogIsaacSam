﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogIsaacSam.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public ActionResult Posts()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }
    }
}