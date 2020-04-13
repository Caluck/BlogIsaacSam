using BlogIsaacSam.Models;
using BlogIsaacSam.Models.Data;
using BlogIsaacSam.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogIsaacSam.Controllers
{
    public class AdminController : Controller
    {
        private IPostRepository db = PostRepositoryFactory.Get();

        [HttpGet]
        public ActionResult AddPost()
        {
            return View(new Post());
        }

        [HttpPost]
        public ActionResult AddPost(Post post, ApplicationUser applicationUser)
        {
            post.Author = applicationUser.UserName;
            post.DateCreated = DateTime.Today;
            db.Add(post);
            return RedirectToAction("Index");
        }
    }
}