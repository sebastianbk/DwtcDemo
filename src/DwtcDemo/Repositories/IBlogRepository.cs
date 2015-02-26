using DwtcDemo.Models;
using System;

namespace DwtcDemo.Repositories
{
    public interface IBlogRepository
    {
        BlogPost GetBlogPost();
    }
}