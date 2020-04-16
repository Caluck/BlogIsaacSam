using BlogIsaacSam.DAL;
using BlogIsaacSam.Models;
using BlogIsaacSam.Models.Data;
using BlogIsaacSam.Models.Data.ViewModelClasses;
using BlogIsaacSam.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogIsaacSam.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository postDb = RepositoryFactory.GetPosts();
        private ICategoryRepository categoryDb = RepositoryFactory.GetCategories();
        private IPostTagRepository postTagDb = RepositoryFactory.GetPostTags();
        private ITagRepository tagDb = RepositoryFactory.GetTags();

        [HttpGet]
        public ActionResult Index()
        {
            List<PostVM> list = new List<PostVM>();
            foreach (var pendingPost in postDb.GetAll())
            {
                PostVM post = new PostVM { Tags = new List<Tag>(), Post = pendingPost };
                post.Category = categoryDb.Get(pendingPost.CategoryId);
                foreach (var postTag in postTagDb.GetAllByPost(pendingPost.PostId))
                {
                    post.Tags.Add(tagDb.Get(postTag.TagId));
                }

                list.Add(post);
            }
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}