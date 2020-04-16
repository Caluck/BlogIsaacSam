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
    public class ModeratorController : Controller
    {
        private IPostRepository postDb = RepositoryFactory.GetPosts();
        private ITagRepository tagDb = RepositoryFactory.GetTags();
        private IPostTagRepository postTagDb = RepositoryFactory.GetPostTags();
        private ICategoryRepository categoryDb = RepositoryFactory.GetCategories();
        private IPendingPostRepository pendingPostDb = RepositoryFactory.GetPendingPosts();

        [HttpGet]
        public ActionResult AddPost()
        {
            return View(new PostAddVM());
        }

        [HttpPost]
        public ActionResult AddPost(PostAddVM postVM)
        {
            //Check if category exists, add if not, don't if so.
            int categoryId = -1;
            foreach (var item in categoryDb.GetAll())
            {
                if (item.Name.Trim() == postVM.CategoryLine.Trim())
                {
                    categoryId = item.CategoryId;
                }
            }
            if (categoryId == -1)
            {
                categoryDb.Add(new Category { Creator = User.Identity.Name, Name = postVM.CategoryLine.Trim(), DateCreated = DateTime.Today });
            }
            //Create & add the new post.
            Post post = new Post
            {
                CategoryId = categoryId,
                Title = postVM.Title,
                Content = postVM.Content,
                Author = User.Identity.Name,
                DateCreated = DateTime.Today,
            };

            pendingPostDb.Create(post);

            //Check for tag's existance & add to PostTag & Tag accordingly
            foreach (var item in postVM.TagLine.Split(','))
            {
                bool tagExists = false;
                foreach (var tag in tagDb.GetAll())
                {
                    if (tag.Name.Trim() == item.Trim())
                    {
                        tagExists = true;
                        postTagDb.Create(new PostTag { TagId = tag.TagId, PostId = postDb.GetAll().Max(x => x.PostId) });
                        break;

                    }
                }
                if (!tagExists)
                {
                    tagDb.Add(new Tag { Name = item.Trim() });
                    postTagDb.Create(new PostTag { TagId = tagDb.GetAll().Max(x => x.TagId), PostId = postDb.GetAll().Max(x => x.PostId) });
                }

            }
            return RedirectToAction("Index", "Home");
        }
    }
}