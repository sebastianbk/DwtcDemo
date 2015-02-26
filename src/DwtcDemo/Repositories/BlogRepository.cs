using DwtcDemo.Models;
using System;

namespace DwtcDemo.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public BlogRepository()
        {

        }

        public BlogPost GetBlogPost()
        {
            var blogPost = new BlogPost
            {
                Id = 1,
                Title = "Dynamicweb Rocks!",
                Content = "This conference is awesome!"
            };

            return blogPost;
        }
    }
}