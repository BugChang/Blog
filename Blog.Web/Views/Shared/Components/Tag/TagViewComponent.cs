using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Views.Shared.Components.Tag
{
    public class TagViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
