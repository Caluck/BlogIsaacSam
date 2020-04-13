using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BlogIsaacSam.Models.Repositories
{
    public class PostRepositoryFactory
    {
        private static IPostRepository repository;

        public static IPostRepository Create()
        {
            string mode = ConfigurationManager.AppSettings["Mode"];

            switch(mode)
            {
                case "EF":
                    return new PostRepositoryEF();
                case "Mock":
                    return new PostRepositoryMock();
                default:
                    throw new Exception("The key 'Mode' in Web.config is set incorrectly.");
            }
        }

        public static IPostRepository Get()
        {
            if (repository == null)
                repository = Create();
            return repository;
        }
    }
}