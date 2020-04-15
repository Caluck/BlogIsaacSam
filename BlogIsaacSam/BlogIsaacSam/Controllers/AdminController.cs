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
        private IPostRepository postDb = RepositoryFactory.GetPosts();
        private ITagRepository tagDb = RepositoryFactory.GetTags();

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
            postDb.Add(post);
            return RedirectToAction("Index");
        }
    }
}