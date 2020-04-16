using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class RepositoryFactory
    {
        private static IPendingPostRepository pendingPostRepository;
        private static ICategoryRepository categoryRepository;
        private static IPostTagRepository postTagRepository;
        private static IPostRepository postRepository;
        private static ITagRepository tagRepository;

        public static void Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"];

            switch(mode)
            {
                case "EF":
                    pendingPostRepository = new PendingPostRepositoryEF();
                    categoryRepository = new CategoryRepositoryEF();
                    postTagRepository = new PostTagRepositoryEF();
                    postRepository = new PostRepositoryEF();
                    tagRepository = new TagRepositoryEF();
                    break;
                case "Mock":
                    pendingPostRepository = new PendingPostRepositoryMock();
                    categoryRepository = new CategoryRepositoryMock();
                    postTagRepository = new PostTagRepositoryEF();
                    postRepository = new PostRepositoryMock();
                    tagRepository = new TagRepositoryMock();
                    break;
                default:
                    throw new Exception("The key 'Mode' in Web.config is set incorrectly.");
            }
        }

        public static IPendingPostRepository GetPendingPosts()
        {
            if (pendingPostRepository == null)
                Create();
            return pendingPostRepository;
        }

        public static ICategoryRepository GetCategories()
        {
            if (categoryRepository == null)
                Create();
            return categoryRepository;
        }

        public static IPostTagRepository GetPostTags()
        {
            if (postTagRepository == null)
                Create();
            return postTagRepository;
        }

        public static IPostRepository GetPosts()
        {
            if (postRepository == null)
                Create();
            return postRepository;
        }

        public static ITagRepository GetTags()
        {
            if (tagRepository == null)
                Create();
            return tagRepository;
        }
    }
}