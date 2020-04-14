using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class RepositoryFactory
    {
        private static ICategoryRepository categoryRepository;
        private static IPostRepository postRepository;

        public static void Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"];

            switch(mode)
            {
                case "EF":
                    categoryRepository = new CategoryRepositoryEF();
                    postRepository = new PostRepositoryEF();
                    break;
                case "Mock":
                    categoryRepository = new CategoryRepositoryMock();
                    postRepository = new PostRepositoryMock();
                    break;
                default:
                    throw new Exception("The key 'Mode' in Web.config is set incorrectly.");
            }
        }

        public static ICategoryRepository GetCategories()
        {
            if (categoryRepository == null)
                Create();
            return categoryRepository;
        }

        public static IPostRepository GetPosts()
        {
            if (postRepository == null)
                Create();
            return postRepository;
        }
    }
}