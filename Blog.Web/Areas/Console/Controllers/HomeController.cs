using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Console.Controllers
{
   
    public class HomeController : ConsoleController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
