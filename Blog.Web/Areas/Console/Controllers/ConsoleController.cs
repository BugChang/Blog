using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Console.Controllers
{
    [Area("Console")]
    [Authorize]
    public class ConsoleController : Controller
    {
    }
}
