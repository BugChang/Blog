﻿using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
