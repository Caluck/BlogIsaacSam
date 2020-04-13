using BlogIsaacSam.DAL;
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
    public class HomeController : Controller
    {
        private IPostRepository db = PostRepositoryFactory.Get();

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.GetAll());
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