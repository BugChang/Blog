using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Views.Shared.Components.Category
{
    public class CategoryViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
