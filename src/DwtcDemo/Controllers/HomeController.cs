using DwtcDemo.Repositories;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DwtcDemo.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepository repo;

        public HomeController(IBlogRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var blogPost = repo.GetBlogPost();

            return View(blogPost);
        }
    }
}
